using DataAccess.Example.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Example.EntityFrmwork
{
    public interface IColorsDataManager
    {
        public void Insert(Color color);

        public void Update(Color color);

        public Color Get(int id);

        public List<Color> GetAll();

        public void Delete(int id);
    }
}
