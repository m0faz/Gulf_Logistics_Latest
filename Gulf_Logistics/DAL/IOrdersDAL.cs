using Gulf_Logistics.Models;

namespace Gulf_Logistics.DAL
{
    public interface IOrdersDAL
    {
        public IEnumerable<Gulf_Logistics.Models.Orders> GetOrderList()
        {
            throw new NotImplementedException();
        }

        public void UploadOrder(List<Orders> orderList)
        {
            throw new NotImplementedException();
        }

        public void EditOrder(int id, Orders order)
        {
            throw new NotImplementedException();
        }



    }
}
