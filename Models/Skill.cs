using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace TEMPLETEAPI.Models
{
    [Table("Skill")]
    public class Skill
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Damage { get; set; }
        public List<CharacterSkill> CharacterSkills { get; set; }
    }
}