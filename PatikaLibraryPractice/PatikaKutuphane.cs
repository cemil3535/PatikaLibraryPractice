using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PatikaLibraryPractice
{
    internal class PatikaKutuphane
    {
        // field identification
        private string _bookName;
        private string _writerName;
        private string _writerSurname;
        private string _publisher;
        private int _numberOfPage;
        private static DateTime _dateOfRegistration;


        public PatikaKutuphane() // null constructor
        {
            _dateOfRegistration = DateTime.Now;
            Console.WriteLine(_dateOfRegistration);
        }

        // constructor gets value
        public PatikaKutuphane(string writerName, string bookName, string publisher, int numberOfPage)
        {
            _bookName = bookName;
            _writerName = writerName;
            _numberOfPage = numberOfPage;
            _publisher = publisher;
            _dateOfRegistration = DateTime.Now;
            Console.WriteLine(_dateOfRegistration);
        }


        //property identification
        public string BookName
        {
            get
            {
                return _bookName;
            }
            set
            {
                _bookName = value;
            }
        }

        public string WriterName
        {
            get
            {
                return _writerName;
            }
            set
            {
                _writerName = value;
            }
        }

        public string WriterSurname
        {
            get
            {
                return _writerSurname;
            }
            set
            {
                _writerSurname = value;
            }
        }

        public string Publisher
        {
            get
            {
                return _publisher;
            }
            set
            {
                _publisher = value;
            }
        }

        public int NumberOfPage
        {
            get
            {
                return _numberOfPage;
            }
            set
            {
                _numberOfPage = value;
            }
        }

        public  DateTime DateOfRegistration
        {
            get
            {
                return _dateOfRegistration;
            }
            set
            {
                _dateOfRegistration = value;
            }
        }

        // display information
        public void DisplayInfo()
        {
            Console.WriteLine($"{WriterName} {WriterSurname}'nin {BookName} adli {Publisher}'den cikan {NumberOfPage} kitabi basarili olarak Patika Kutuphanesine eklendi"); 
        }

    }
}
