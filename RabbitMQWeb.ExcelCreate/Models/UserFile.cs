using System.ComponentModel.DataAnnotations.Schema;

namespace RabbitMQWeb.ExcelCreate.Models
{
    public enum FileStatus
    {
        Creating,
        Complete
    }



    public class UserFile
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public DateTime? CreateDate { get; set; }
        public FileStatus FileStatus { get; set; }
        [NotMapped]
        public string GetCreateDate => CreateDate.HasValue ? CreateDate.Value.ToShortDateString() : "-";   //null olup olmadığı kontrol edildi.

       
    }
}
