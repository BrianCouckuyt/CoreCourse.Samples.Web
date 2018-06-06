using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreCourse.Samples.Web.Entities
{
    public class Item
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        [ForeignKey("User")]
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}