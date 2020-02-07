using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spice.Models.ViewModels
{
    public class SubCategoryAndCategoryModel
    {

        /// <summary>
        /// View Model này dùng để hiển thị Hai Model Category và SubCategory để sử dụng trong View và Controller SubCategory
        /// </summary>
        public IEnumerable<Category> CategoryList { get; set; }

        public SubCategory SubCategory { get; set; }

        public List<string> SubCategoryList { get; set; }

        public string StatusMessage { get; set; }
    }
}
