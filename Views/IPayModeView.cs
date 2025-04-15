using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Views
{
    internal interface IPayModeView
    {
        //propiedades
        String PayModeId { get; set; }
        string PayModeName { get; set; }
        string PayModeObservation { get; set; }

        string SearchaValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }
    
        //eventos 
        event EventHandler SearchEvent;
        event EventHandler AddNewEven;
        event EventHandler EditEvent;
        event EventHandler DeleteEven;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        //metodos
        void SetPayModeListBildingsource(BindingSource payModeList);
        void show();



    }
}
