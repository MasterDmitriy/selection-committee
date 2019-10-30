﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SelectionCommittee.BLL.DataTransferObject
{
    public class SpecialtyDTO
    {
        public int Id { get; set; }
        public int Number { get; set; }

        public string Name { get; set; }

        public int BudgetPlaces { get; set; }

        public int TotalPlaces { get; set; }

        public string Description { get; set; }

        public int FacultyId { get; set; }
        public string Photo { get; set; }

    }
}
