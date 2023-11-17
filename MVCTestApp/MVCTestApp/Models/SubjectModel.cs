
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MVCTestApp.Models
{
    public class SubjectModel
    {

            public SubjectModel()
            {
            SubjectList = new List<SelectListItem>();
            }

            [DisplayName("Subjects")]
            public List<SelectListItem> SubjectList { get; set; }

            public List<SelectListItem> SelectedSubject { get; set; }

    }

}

