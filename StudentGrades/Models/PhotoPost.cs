using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentGrades
{
    ///<summary>
    /// This class stores information about a Photo posts in a social network. 
    /// The main part of the post consists of a photo and a caption. 
    /// Other data, such as author and time, are also stored.
    ///</summary>
    /// <author>
    /// Yamin Hassan
    /// @version 0.1
    /// </author>
    public class PhotoPost: Post
    {
        // the name of the image file
        [Column("File Name")]
        public String Filename { get; set; }
        [Column("Caption")]
        // a one line image caption
        public String Caption { get; set; }      
        
        ///<summary>
        /// Constructor for objects of class PhotoPost.
        ///</summary>
        /// <param name="author">
        /// The username of the author of this post.
        /// </param>
        /// <param name="caption">
        /// A caption for the image.
        /// </param>
        /// <param name="filename">
        /// The filename of the image in this post.
        /// </param>
        public PhotoPost() 
        {           
               
        }
        
        public int ReturnImageId()
        {
            return ID;
        }
        public override void Display()
        {
            Console.WriteLine("________________________________________________________________________");
            base.Display();
            Console.WriteLine();
            Console.WriteLine($"\tFilename: [{Filename}]");
            Console.WriteLine($"\tCaption: {Caption}");
            Console.WriteLine("__________________________________________________________________________");
        }        
    }
}
