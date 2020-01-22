using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTest
    {

        [Fact]
        public void Test1()
        {
            var book1 =  GetBook("Book 1");

            SetName(book1, "New Name");
            
            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
            Assert.NotSame(book1, book2);
        }

        private void SetName(Book book1, string v)
        {
            
        }

        [Fact]
        public void GetBookReturnsDifferentObject()
        {
            var book1 =  GetBook("Book 1");
            var book2 =  GetBook("Book 2");

            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
            Assert.NotSame(book1, book2);
        }

        [Fact]
        public void TwoVariablesCanReferenceSameObject()
        {
           
            var book1 =  GetBook("Book 1");
            var book2 =  book1;

           Assert.Same(book1, book2);
           Assert.True(object.ReferenceEquals(book1, book2));
         
          
        }

        Book GetBook(string name) // default means this method is private
        {
            return new Book(name); 
        }
    }
}