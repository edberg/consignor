using System;
using System.ServiceModel;
using Consignor.ShipAdvisor;

namespace Consignor.Internal
{
    [ServiceContract(Namespace = "http://ws.consignorsupport.no/ShipAdvisor")]
    [XmlSerializerFormat]
    internal interface IShipAdvisorAsync
    {
        [OperationContract(AsyncPattern = true, Action = "http://ws.consignorsupport.no/ShipAdvisor/CancelChodOrder")]
        IAsyncResult BeginCancelChodOrder(long ChODId, AsyncCallback callback, object state);
        string EndCancelChodOrder(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "http://ws.consignorsupport.no/ShipAdvisor/CancelConfirmedOrder")]
        IAsyncResult BeginCancelConfirmedOrder(long ChODId, AsyncCallback callback, object state);
        string EndCancelConfirmedOrder(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "http://ws.consignorsupport.no/ShipAdvisor/ConfirmChodOrder")]
        IAsyncResult BeginConfirmChodOrder(long ChODId, AsyncCallback callback, object state);
        string EndConfirmChodOrder(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "http://ws.consignorsupport.no/ShipAdvisor/CreateConfirmedOrder")]
        IAsyncResult BeginCreateConfirmedOrder(WebShopShipment Shipment, SelectedProduct Product, AsyncCallback callback, object state);
        OrderOutput EndCreateConfirmedOrder(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "http://ws.consignorsupport.no/ShipAdvisor/ExportWebShop")]
        IAsyncResult BeginExportWebShop(int WebShopId, AsyncCallback callback, object state);
        string EndExportWebShop(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "http://ws.consignorsupport.no/ShipAdvisor/GetChODAllDropPointsOnMap")]
        IAsyncResult BeginGetChODAllDropPointsOnMap(int webShopId, string productConceptIds, string webshopProductIds, string installationId, string postCode, string country, decimal mapWidth, decimal mapHeight, AsyncCallback callback, object state);
        MasterDropPointWrapper EndGetChODAllDropPointsOnMap(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "http://ws.consignorsupport.no/ShipAdvisor/GetChODAllDropPointsWithinBounds")]
        IAsyncResult BeginGetChODAllDropPointsWithinBounds(int webShopId, string productConceptIds, string webshopProductIds, string installationId, decimal ne_lat, decimal ne_lng, decimal sw_lat, decimal sw_lng, AsyncCallback callback, object state);
        MasterDropPointWrapper EndGetChODAllDropPointsWithinBounds(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "http://ws.consignorsupport.no/ShipAdvisor/GetChODCarrierDropPointsOnMap")]
        IAsyncResult BeginGetChODCarrierDropPointsOnMap(string productConceptIds, string installationId, string postCode, string country, decimal mapWidth, decimal mapHeight, AsyncCallback callback, object state);
        MasterDropPointWrapper EndGetChODCarrierDropPointsOnMap(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "http://ws.consignorsupport.no/ShipAdvisor/GetChODCarrierDropPointsWithinBounds")]
        IAsyncResult BeginGetChODCarrierDropPointsWithinBounds(string productConceptIds, string installationId, decimal ne_lat, decimal ne_lng, decimal sw_lat, decimal sw_lng, AsyncCallback callback, object state);
        MasterDropPointWrapper EndGetChODCarrierDropPointsWithinBounds(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "http://ws.consignorsupport.no/ShipAdvisor/GetChodOrder")]
        IAsyncResult BeginGetChodOrder(long ChODId, OrderStatus status, AsyncCallback callback, object state);
        WebShopShipment EndGetChodOrder(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "http://ws.consignorsupport.no/ShipAdvisor/GetChODWebShopDropPointsOnMap")]
        IAsyncResult BeginGetChODWebShopDropPointsOnMap(int webShopId, string webshopProductIds, string installationId, string postCode, string country, decimal mapWidth, decimal mapHeight, AsyncCallback callback, object state);
        MasterDropPointWrapper EndGetChODWebShopDropPointsOnMap(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "http://ws.consignorsupport.no/ShipAdvisor/GetChODWebShopDropPointsWithinBounds")]
        IAsyncResult BeginGetChODWebShopDropPointsWithinBounds(int webShopId, string webshopProductIds, string installationId, decimal ne_lat, decimal ne_lng, decimal sw_lat, decimal sw_lng, AsyncCallback callback, object state);
        MasterDropPointWrapper EndGetChODWebShopDropPointsWithinBounds(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "http://ws.consignorsupport.no/ShipAdvisor/GetClosestDropPoint")]
        IAsyncResult BeginGetClosestDropPoint(int productConceptID, string installationID, string postCode, string country, AsyncCallback callback, object state);
        DropPointData EndGetClosestDropPoint(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "http://ws.consignorsupport.no/ShipAdvisor/GetFreightProducts")]
        IAsyncResult BeginGetFreightProducts(long ChODId, int deliveryTypeOrder, AsyncCallback callback, object state);
        ProductsWrapper EndGetFreightProducts(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "http://ws.consignorsupport.no/ShipAdvisor/GetFreightProductsForShipment")]
        IAsyncResult BeginGetFreightProductsForShipment(WebShopShipment Shipment, int deliveryTypeOrder, AsyncCallback callback, object state);
        ProductsWrapper EndGetFreightProductsForShipment(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "http://ws.consignorsupport.no/ShipAdvisor/GetPrices")]
        IAsyncResult BeginGetPrices(WebShopShipment Shipment, long[] WebShopProductIds, AsyncCallback callback, object state);
        ProductsWrapper EndGetPrices(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "http://ws.consignorsupport.no/ShipAdvisor/GetShipmentByOrder")]
        IAsyncResult BeginGetShipmentByOrder(string orderNumber, string installationID, int actorID, AsyncCallback callback, object state);
        GetShipmentByOrderOutput EndGetShipmentByOrder(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "http://ws.consignorsupport.no/ShipAdvisor/ImportWebShop")]
        IAsyncResult BeginImportWebShop(string FileContent, AsyncCallback callback, object state);
        string EndImportWebShop(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "http://ws.consignorsupport.no/ShipAdvisor/OrderInitialize")]
        IAsyncResult BeginOrderInitialize(WebShopShipment Shipment, string ReturnUrl, string CancelUrl, string Hash, AsyncCallback callback, object state);
        OrderInitializeOutput EndOrderInitialize(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "http://ws.consignorsupport.no/ShipAdvisor/SearchForDropPoints")]
        IAsyncResult BeginSearchForDropPoints(int productConceptID, string installationID, string country, string address, string postCode, string city, int limit, AsyncCallback callback, object state);
        DropPointData[] EndSearchForDropPoints(IAsyncResult result);

        [OperationContract(AsyncPattern = true, Action = "http://ws.consignorsupport.no/ShipAdvisor/UpdateChodOrder")]
        IAsyncResult BeginUpdateChodOrder(long ChODId, WebShopShipment shipment, SelectedProduct selectedProduct, OrderStatus status, AsyncCallback callback, object state);
        string EndUpdateChodOrder(IAsyncResult result);
    }
}