using System;
using System.Collections.Generic;
using ToDoList.Models;
namespace ToDoList
{
    class Program
    {
        public static Board _board { get; set; }
        public static MemberList _members { get; set; }

        static void Main(string[] args)
        {
            _board = new Board();
            _members = new MemberList();

            while (true)
            {
                Page();
            }
        }

        public static void Page()
        {
            int check;
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Board Listelemek");// getBoard ve printLine metotları çağrılır.
            Console.WriteLine("(2) Board'a Kart Eklemek");
            Console.WriteLine("(3) Board'dan Kart Silmek");
            Console.WriteLine("(4) Kart Taşımak");
            check = Int32.Parse(Console.ReadLine());

            switch (check)
            {
                case 1:
                    getBoard();
                    break;
                case 2:
                    newCard();
                    break;
                case 3:
                    removeCard();
                    break;
                //case 4:
                //    moveCard();
                //    break;
                default:
                    Console.WriteLine("Geçersiz seçim yaptınız!");
                    break;
            }
        }

        public static void getBoard()
        {
            Console.WriteLine("TODO Line");
            Console.WriteLine("*********************");

            if (_board.TODO.Count > 0)
                printLine(_board.TODO, _members);
            else
                Console.WriteLine("~BOŞ~");
            /////////////////////////////////////////////////
            Console.WriteLine("IN PROGRESS Line");
            Console.WriteLine("*********************");

            if (_board.IN_PROGRESS.Count > 0)
                printLine(_board.TODO, _members);
            else
                Console.WriteLine("~BOŞ~");
            /////////////////////////////////////////////////
            Console.WriteLine("DONE Line");
            Console.WriteLine("*********************");
            if (_board.DONE.Count > 0)
                printLine(_board.DONE, _members);
            else
                Console.WriteLine("~BOŞ~");

        }

        //Kolanları yazdıran Metot
        public static void printLine(List<Card> col, MemberList members)
        {
            foreach (var item in col)
            {
                Console.WriteLine("Başlık      : {0}", item.Title);
                Console.WriteLine("İçerik      : {0}", item.Content);
                Console.WriteLine("Atanan Kişi : {0}", members.all.Find(x => x.Id == item.Id).FullName);
                Console.WriteLine("Büyüklük    : {0}", ((Size)item.Size).ToString());
                Console.WriteLine("-");
            }
        }

        private static void newCard()
        {
            string _title;
            string _content;
            int _size;
            int _memberId;

            Console.WriteLine("Başlık Giriniz                                  :");
            _title = Console.ReadLine();
            Console.WriteLine("İçerik Giriniz                                  :");
            _content = Console.ReadLine();
            Console.WriteLine("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  :");
            _size = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Kişi Seçiniz (1-5 arası bir rakam)              :");
            _memberId = Int32.Parse(Console.ReadLine());

            _board.TODO.Add(new Card(_title, _content, _memberId, _size));

        }

        //Kart silme
        private static void removeCard()
        {
            string _title;
            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine("Lütfen kart başlığını yazınız:");
            _title = Console.ReadLine();

            int todo;
            int inProgress;
            int done;

            todo = _board.TODO.FindIndex(x => x.Title.ToLower() == _title.ToLower());
            inProgress = _board.TODO.FindIndex(x => x.Title == _title.ToLower());
            done = _board.TODO.FindIndex(x => x.Title == _title.ToLower());

            if (todo >= 0)
                _board.TODO.RemoveAt(todo);
            else if (inProgress >= 0)
                _board.IN_PROGRESS.RemoveAt(inProgress);
            else if (done >= 0)
                _board.DONE.RemoveAt(done);
            else
            {
                Console.WriteLine("Aradığınız kart bulunamadı.");
                Page();
            }
            Console.WriteLine("İşlem başarılı bir şekilde tamamlandı.");
        }



    }
}