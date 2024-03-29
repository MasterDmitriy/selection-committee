﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SelectionCommittee.DAL.Entities
{
    public class Region
    {
        [Key]
        public int Id { set; get; }
        public string Name { get; set; }
        public IList<City> Cities { get; set; }
        public ICollection<Enrollee> Enrollees { set; get; }

        public IList<EducationalInstitution> EducationalInstitutions { set; get; }
        public Region()
        {
            Enrollees = new List<Enrollee>();
            Cities = new List<City>();
            EducationalInstitutions = new List<EducationalInstitution>();
        }
    }
}
