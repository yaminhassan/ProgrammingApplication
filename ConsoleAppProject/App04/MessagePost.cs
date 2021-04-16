using System;
using System.Collections.Generic;
namespace ConsoleAppProject.App04
{
    ///<summary>
    /// This class stores information about a post in a social network. 
    /// The main part of the post consists of a (possibly multi-line)
    /// text message. Other data, such as author and time, are also stored.
    /// </summary>
    /// <author>
    /// Michael Kölling and David J. Barnes
    /// version 0.1
    /// </author>
    public class MessagePost: Post
    {
        
        public String Message { get; }

        public MessagePost(String author, String message) : base(author)
        {           
           this.Message = message;
        }
        
        public override void Display()
        {
            Console.WriteLine("__________________________________________________________________");
            base.Display();
            Console.WriteLine();
            Console.WriteLine($"\t\tMessage: [{Message}]");
            Console.WriteLine("___________________________________________________________________");
        }
        
        public override string ToString()
        {


            return "ID:" + ID + "\n\t User Name:" + Username + "\n\t Time" + Timestamp +
                 "\n\t Likes: " + Likes;
            
            
            

        }

    }
}
