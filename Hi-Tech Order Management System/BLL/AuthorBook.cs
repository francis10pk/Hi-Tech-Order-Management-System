﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hi_Tech_Order_Management_System.BLL
{
    public class AuthorBook
    {
        public int AuthorId { get; set; }
        public string Isbn { get; set; }

        // Navigation property to the Author entity
        public Author Author { get; set; }

        // Navigation property to the Book entity
        public Book Book { get; set; }
    }
}