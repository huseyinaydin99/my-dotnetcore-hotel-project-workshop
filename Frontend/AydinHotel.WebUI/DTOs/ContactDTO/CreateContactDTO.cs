using System;

namespace AydinHotel.WebUI.DTOs.ContactDTO
{
    public class CreateContactDTO
    {
        //public int ContactId { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
        public int MessageCategoryId { get; set; }
    }
}
