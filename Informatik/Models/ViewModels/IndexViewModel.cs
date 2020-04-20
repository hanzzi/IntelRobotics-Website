using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace Informatik.Models
{
    public class IndexViewModel
    {
        public Product FirstLook;
        public List<Product> Flagships = new List<Product>();

        public IndexViewModel()
        {
            FirstLook = new Product
            {
                ID = 1,
                Name = "Robot",
                Descriptions = new List<Description>{ new Description
                {
                    ID = 1,
                    Descripton = "DESCRIPTION HERE",
                    Parent = FirstLook,
                    ShortDescription = "ShortDescription"
                }
                }

            };
            Flagships.Add(new Product
            {
                Name = "Robot1",
                Descriptions = new List<Description>{ new Description
                {
                    ID = 1,
                    Descripton = "Robot1 Description",
                    ShortDescription = "Robot1 ShortDescription"
                }
                }
            });

            Flagships.Add(new Product
            {
                Name = "Robot2",
                Descriptions = new List<Description>{ new Description
                {
                    ID = 1,
                    Descripton = "Robot2 Description",
                    ShortDescription = "Robot2 ShortDescription"
                }
                }
            });


        }
        
    }
}
