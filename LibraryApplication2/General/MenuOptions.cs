using CommonClasses;
using LibraryRepository.Models;
using LibraryRepository.Repositories;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApplication2
{
    class MenuOptions
    {
        public static void CreateBook()
        {
            StandardMessages.CreateMessage("a Book");
            Book book = ItemDataCapture.Book();
            BookRepository.SaveBookToDB(book);
            StandardMessages.WasCreatedMessage("book");
        }

        public static void CreateMovie()
        {
            StandardMessages.CreateMessage("a Movie");
            Movie movie = ItemDataCapture.Movie();
            MovieRepository.SaveMovieToDB(movie);
            StandardMessages.WasCreatedMessage("book");
        }

        public static void UpdateBook()
        {
            Book bookToUpdate = SelectBookById.SelectBook("update");
            if (bookToUpdate != null)
            {
                Book updatedBook = ItemDataCapture.Book();
                BookRepository.UpdateBook(bookToUpdate.Id, updatedBook);
                StandardMessages.UpdatedMessage("book");
            }
        }

        public static void UpdateMovie()
        {
            Movie movieToUpdate = SelectMovieById.SelectMovie("update");
            if (movieToUpdate != null)
            {
                Movie updatedMovie = ItemDataCapture.Movie();
                MovieRepository.UpdateMovie(movieToUpdate.Id, updatedMovie);
                StandardMessages.UpdatedMessage("movie");
            }
        }
        public static void CreateMember()
        {
            StandardMessages.CreateMessage("a Member");
            Member member = MemberDataCapture.Member();
            MemberRepository.SaveMemberToDB(member);
            StandardMessages.WasCreatedMessage("member");
        }
        public static void UpdateMember()
        {
            Member memberToUpdate = SelectMemberById.SelectMember("update");
            if (memberToUpdate != null)
            {
                Member updatedMember = MemberDataCapture.Member();
                MemberRepository.UpdateMember(memberToUpdate.Id, updatedMember.Name, updatedMember.Age);
                StandardMessages.UpdatedMessage("member");
            }
        }
        public static void ReturnItemMenu()
        {
            Member member = SelectMemberById.SelectMember("return an item");
            if (member != null)
            {
                MenuSwitches.ReturnItem(member);
            }
        }
        public static void BorrowBookMenu()
        {
            Member member = SelectMemberById.SelectMember("lend a book to");
            LoanProcess.BorrowABook(member);
        }
        public static void BorrowMovieMenu()
        {
            Member member = SelectMemberById.SelectMember("lend a book to");
            LoanProcess.BorrowAMovie(member);
        }
    }
}
