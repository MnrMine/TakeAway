﻿namespace TakeAway.Comment.Dtos
{
    public class CreateUserCommentDto
    {
       
        public string NameSurname { get; set; }
        public string Email { get; set; }
        public string UserId { get; set; }
        public string CommentDetail { get; set; }
        public string CreatedDate { get; set; }
        public string ProductId { get; set; }
        public bool Status { get; set; }
    }
}
