using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework
{
    public class Person
    {
        public Int64 Id { get; set; } //注意要用Int64

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }

    [Table("Announcement")]
    public class Announcement
    {
        public Announcement()
        {
            CreateTime = DateTime.Now;
        }

        [Key]
        [Display(Name = "公告ID")]
        public Int64 AnnouncementId { set; get; }

        [Display(Name = "发布人")]
        public int? MemberId { set; get; }

        [Display(Name = "公告标题")]
        [Required(ErrorMessage = "公告标题必须填写")]
        [StringLength(100, ErrorMessage = "公告标题必须小于100个字", MinimumLength = 2)]
        public string Title { set; get; }

        [Display(Name = "公告内容")]
        [Required(ErrorMessage = "公告内容必须填写")]
        public string Content { set; get; }

        [Display(Name = "发布时间")]
        public DateTime CreateTime { set; get; }
    }

    public class PitmanContext : DbContext
    {
        public PitmanContext()
            : base("Pitman")
        {
            //数据库不存在时重新创建数据库
            Database.SetInitializer<PitmanContext>(new CreateDatabaseIfNotExists<PitmanContext>());

            //每次启动应用程序时创建数据库
            //Database.SetInitializer<PitmanContext>(new DropCreateDatabaseAlways<PitmanContext>());

            //模型更改时重新创建数据库
            //Database.SetInitializer<PitmanContext>(new DropCreateDatabaseIfModelChanges<PitmanContext>());

            //从不创建数据库
            //Database.SetInitializer<PitmanContext>(null);
        }

        public DbSet<Person> Persons { get; set; }

        public DbSet<Announcement> Announcement { get; set; }
    }
}
