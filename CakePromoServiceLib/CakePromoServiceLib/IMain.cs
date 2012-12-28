using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Collections;
using System.ServiceModel.Web;

using CakePromo.BusinessLogic;

namespace CakePromoServiceLib
{
    //The ServiceKnownType is needed in the case where the return type is ICollection with different bject types.
    [ServiceKnownType(typeof(Cake))]
    [ServiceKnownType(typeof(Rate))]
    [ServiceKnownType(typeof(CakePhoto))]
    [ServiceKnownType(typeof(Ingredient))]
    [ServiceKnownType(typeof(Unit))]
    [ServiceContract]
    interface IMain
    {
        //[OperationContract]
        //List<Cake> GetCake();

        [OperationContract]
        List<ICollection> GetAllCakesEager();

        [OperationContract]
        Cake GetCakeByID(int id);

        [OperationContract]
        List<Ingredient> GetIngredientsByCakeID(int CakeID);
        
        [OperationContract]        
        List<Cake> GetAllCakes();
    }
}
