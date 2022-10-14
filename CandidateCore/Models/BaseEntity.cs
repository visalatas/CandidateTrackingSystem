using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateCore.Models
{
    public class BaseEntity<TPrimaryKey>
    {
        //Generic bir sınıf tanımladık.
        public TPrimaryKey Id { get; set; }
        public DateTime CreateData { get; set; }
        public DateTime UpdateData { get; set; }
        public int CreateUserId { get; set; }
        public int UpdateUserId { get; set; }
        //generic olacak(T),ıd tipi geceric olacak, id,createData, UpdateData.CreateUserId Updateuserıd ,bu classın aynısının generic olmayanı olacak ve default id tipi int olacak
    }

    public class BaseEntity : BaseEntity<int>
    {
       

    }
}
