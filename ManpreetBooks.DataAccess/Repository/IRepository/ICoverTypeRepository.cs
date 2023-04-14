using ManpreetBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManpreetBooks.DataAccess.Repository.IRepository
{
    public interface ICoverTypeRepository : IRepository<CoverType>
    {
        void Update(CoverType coverType);
    }
}
