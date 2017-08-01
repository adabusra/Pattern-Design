﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulamlar
{
    class DecoratorTwo
    {
        static void Main()
        {
            Book book = new Book("Worley", "Inside ASP.NET", 10);
            book.Display();


            Video video = new Video("Spielberg", "Jaws", 23, 92);
            video.Display();

            Console.WriteLine("\nMaking video borrowable: ");

            Borrowable borrowvideo = new Borrowable(video);
            borrowvideo.BorrowItem("Customer #1");
            borrowvideo.BorrowItem("Customer #2");

            borrowvideo.Display();

            Console.ReadKey();
        }
    }

    abstract class LibraryItem
    {
        private int _numCopies;

        public int NumCopies
        {
            get { return _numCopies; }
            set { _numCopies = value; }
        }

        public abstract void Display();
    }

    class Book : LibraryItem
    {
        private string _author;
        private string _title;

        public Book(string author, string title,int numCopies)
        {
            this._title = author;
            this._title = title;
            this.NumCopies = numCopies;
        }

        public override void Display()
        {
            Console.WriteLine("\nBook ---------");
            Console.WriteLine(" Author: {0}", _author);
            Console.WriteLine(" Title: {0}", _title);
            Console.WriteLine(" # Copies: {0}", NumCopies);
        }

    }

    class Video : LibraryItem
    {
        private string _director;
        private string _title;
        private int _playTime;

        public Video(string director, string title, int numCopies, int playTime)
        {
            this._director = director;
            this._title = title;
            this.NumCopies = numCopies;
            this._playTime = playTime;
        }

        public override void Display()
        {
            Console.WriteLine("\nVideo ---------");
            Console.WriteLine(" Director: {0}", _director);
            Console.WriteLine(" Title: {0}", _title);
            Console.WriteLine(" # Copies: {0}", NumCopies);
            Console.WriteLine(" Playtime: {0}\n", _playTime);
        }
    }

    abstract class Decoratorrr : LibraryItem
    {
        protected LibraryItem libraryItem;

        public Decoratorrr(LibraryItem libraryItem)
        {
            this.libraryItem = libraryItem;
        }
        public override void Display()
        {
            libraryItem.Display();
        }
    }

    class Borrowable : Decoratorrr
    {
        protected List<string> borrowers = new List<string>();

        public Borrowable(LibraryItem librarItem) : base(librarItem)
        {

        }

        public void BorrowItem(string name)
        {
            borrowers.Add(name);
            libraryItem.NumCopies--;
        }

        public void ReturnItem(string name)
        {
            borrowers.Remove(name);
            libraryItem.NumCopies++;
        }
        public override void Display()
        {
            base.Display();

            foreach (string borrower in borrowers)
            {
                Console.WriteLine(" borrower: " + borrower);
            }
        }

    }
}
