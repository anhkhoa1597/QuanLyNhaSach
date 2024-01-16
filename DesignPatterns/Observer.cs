using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM
{
    public interface ISubcriber
    {
        void UpdateByPublisher(); // Cập nhật thông tin
    }

    public interface IPublisher
    {
        void Subcribe(ISubcriber subcriber);
        void Unsubcribe(ISubcriber subcriber);
        void Notify();
    }
}

