#region Copyright Syncfusion Inc. 2001-2016.
// Copyright Syncfusion Inc. 2001-2016. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using EditingAndDataValidation.DataModel;
using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace EditingAndDataValidation
{
	public class ViewModel : NotificationObject
	{
		private List<string> _comboBoxItemsSource = new List<string>();



		private ObservableCollection<ProductInfo> _productList = new ObservableCollection<ProductInfo>();

		private ObservableCollection<OrderInfo> _orderList = new ObservableCollection<OrderInfo>();

		/// <summary>
		/// Gets or sets the order list.
		/// </summary>
		/// <value>The order list.</value>
		public ObservableCollection<OrderInfo> OrderList
		{
			get
			{
				return _orderList;
			}
			set
			{
				_orderList = value;
				RaisePropertyChanged("OrderList");
			}
		}


		public ObservableCollection<ProductInfo> ProductList
		{
			get
			{
				return _productList;
			}
			set
			{
				_productList = value;
				RaisePropertyChanged("ProductList");
			}
		}

		public List<string> ComboBoxItemsSource
		{
			get { return _comboBoxItemsSource; }
			set { _comboBoxItemsSource = value; }
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="ViewModel"/> class.
		/// </summary>
		public ViewModel()
		{
			PopulateData();
		}

		/// <summary>
		/// Populates the data.
		/// </summary>
		private void PopulateData()
		{
			OrderInfo orderInfo = new OrderInfo();
			Random r = new Random();

			orderInfo.OrderID = 1;
			orderInfo.CustomerID = "CustomerID";
			orderInfo.ProductCode = "prod1";
			orderInfo.UnitPrice = 3.0;
			orderInfo.Quantity = 7;
			orderInfo.Discount = 3.0;
			orderInfo.Freight = 1.7;
			orderInfo.OrderDate = DateTime.Now; ;
			orderInfo.ShippedDate = DateTime.Now;
			orderInfo.ShipPostalCode = "ShipPostalCode";
			orderInfo.ShipAddress = "ShipAddress";
			orderInfo.IsClosed = true;
			orderInfo.ContactNumber = r.Next(999111, 999119).ToString();
			orderInfo.DeliveryDelay = orderInfo.ShippedDate - orderInfo.OrderDate;
			_orderList.Add(orderInfo);

			orderInfo = new OrderInfo();
			orderInfo.OrderID = 2;
			orderInfo.CustomerID = "CustomerID";
			orderInfo.ProductCode = "prod2";
			orderInfo.UnitPrice = 3.0;
			orderInfo.Quantity = 7;
			orderInfo.Discount = 3.0;
			orderInfo.Freight = 1.7;
			orderInfo.OrderDate = DateTime.Now; ;
			orderInfo.ShippedDate = DateTime.Now;
			orderInfo.ShipPostalCode = "ShipPostalCode";
			orderInfo.ShipAddress = "ShipAddress";
			orderInfo.IsClosed = true;
			orderInfo.ContactNumber = r.Next(999111, 999119).ToString();
			orderInfo.DeliveryDelay = orderInfo.ShippedDate - orderInfo.OrderDate;
			_orderList.Add(orderInfo);

            orderInfo = new OrderInfo();
            orderInfo.OrderID = 3;
            orderInfo.CustomerID = "CustomerID";
            orderInfo.ProductCode = "car";
            orderInfo.UnitPrice = 3.0;
            orderInfo.Quantity = 7;
            orderInfo.Discount = 3.0;
            orderInfo.Freight = 1.7;
            orderInfo.OrderDate = DateTime.Now; ;
            orderInfo.ShippedDate = DateTime.Now;
            orderInfo.ShipPostalCode = "ShipPostalCode";
            orderInfo.ShipAddress = "ShipAddress";
            orderInfo.IsClosed = true;
            orderInfo.ContactNumber = r.Next(999111, 999119).ToString();
            orderInfo.DeliveryDelay = orderInfo.ShippedDate - orderInfo.OrderDate;
            _orderList.Add(orderInfo);

            orderInfo.OrderID = 4;
            orderInfo.CustomerID = "CustomerID";
            orderInfo.ProductCode = "prod1";
            orderInfo.UnitPrice = 3.0;
            orderInfo.Quantity = 7;
            orderInfo.Discount = 3.0;
            orderInfo.Freight = 1.7;
            orderInfo.OrderDate = DateTime.Now; ;
            orderInfo.ShippedDate = DateTime.Now;
            orderInfo.ShipPostalCode = "ShipPostalCode";
            orderInfo.ShipAddress = "ShipAddress";
            orderInfo.IsClosed = true;
            orderInfo.ContactNumber = r.Next(999111, 999119).ToString();
            orderInfo.DeliveryDelay = orderInfo.ShippedDate - orderInfo.OrderDate;
            _orderList.Add(orderInfo);

            orderInfo = new OrderInfo();
            orderInfo.OrderID = 5;
            orderInfo.CustomerID = "CustomerID";
            orderInfo.ProductCode = "prod2";
            orderInfo.UnitPrice = 3.0;
            orderInfo.Quantity = 7;
            orderInfo.Discount = 3.0;
            orderInfo.Freight = 1.7;
            orderInfo.OrderDate = DateTime.Now; ;
            orderInfo.ShippedDate = DateTime.Now;
            orderInfo.ShipPostalCode = "ShipPostalCode";
            orderInfo.ShipAddress = "ShipAddress";
            orderInfo.IsClosed = true;
            orderInfo.ContactNumber = r.Next(999111, 999119).ToString();
            orderInfo.DeliveryDelay = orderInfo.ShippedDate - orderInfo.OrderDate;
            _orderList.Add(orderInfo);

            orderInfo = new OrderInfo();
            orderInfo.OrderID = 6;
            orderInfo.CustomerID = "CustomerID";
            orderInfo.ProductCode = "car";
            orderInfo.UnitPrice = 3.0;
            orderInfo.Quantity = 7;
            orderInfo.Discount = 3.0;
            orderInfo.Freight = 1.7;
            orderInfo.OrderDate = DateTime.Now; ;
            orderInfo.ShippedDate = DateTime.Now;
            orderInfo.ShipPostalCode = "ShipPostalCode";
            orderInfo.ShipAddress = "ShipAddress";
            orderInfo.IsClosed = true;
            orderInfo.ContactNumber = r.Next(999111, 999119).ToString();
            orderInfo.DeliveryDelay = orderInfo.ShippedDate - orderInfo.OrderDate;
            _orderList.Add(orderInfo);

            orderInfo.OrderID = 9;
            orderInfo.CustomerID = "CustomerID";
            orderInfo.ProductCode = "prod1";
            orderInfo.UnitPrice = 3.0;
            orderInfo.Quantity = 7;
            orderInfo.Discount = 3.0;
            orderInfo.Freight = 1.7;
            orderInfo.OrderDate = DateTime.Now; ;
            orderInfo.ShippedDate = DateTime.Now;
            orderInfo.ShipPostalCode = "ShipPostalCode";
            orderInfo.ShipAddress = "ShipAddress";
            orderInfo.IsClosed = true;
            orderInfo.ContactNumber = r.Next(999111, 999119).ToString();
            orderInfo.DeliveryDelay = orderInfo.ShippedDate - orderInfo.OrderDate;
            _orderList.Add(orderInfo);

            orderInfo = new OrderInfo();
            orderInfo.OrderID = 8;
            orderInfo.CustomerID = "CustomerID";
            orderInfo.ProductCode = "prod2";
            orderInfo.UnitPrice = 3.0;
            orderInfo.Quantity = 7;
            orderInfo.Discount = 3.0;
            orderInfo.Freight = 1.7;
            orderInfo.OrderDate = DateTime.Now; ;
            orderInfo.ShippedDate = DateTime.Now;
            orderInfo.ShipPostalCode = "ShipPostalCode";
            orderInfo.ShipAddress = "ShipAddress";
            orderInfo.IsClosed = true;
            orderInfo.ContactNumber = r.Next(999111, 999119).ToString();
            orderInfo.DeliveryDelay = orderInfo.ShippedDate - orderInfo.OrderDate;
            _orderList.Add(orderInfo);

            orderInfo = new OrderInfo();
            orderInfo.OrderID = 7;
            orderInfo.CustomerID = "CustomerID";
            orderInfo.ProductCode = "car";
            orderInfo.UnitPrice = 3.0;
            orderInfo.Quantity = 7;
            orderInfo.Discount = 3.0;
            orderInfo.Freight = 1.7;
            orderInfo.OrderDate = DateTime.Now; ;
            orderInfo.ShippedDate = DateTime.Now;
            orderInfo.ShipPostalCode = "ShipPostalCode";
            orderInfo.ShipAddress = "ShipAddress";
            orderInfo.IsClosed = true;
            orderInfo.ContactNumber = r.Next(999111, 999119).ToString();
            orderInfo.DeliveryDelay = orderInfo.ShippedDate - orderInfo.OrderDate;
            _orderList.Add(orderInfo);


            _productList.Add(new ProductInfo { Code = "prod1", Description = "England" });
			_productList.Add(new ProductInfo { Code = "prod2", Description = "UK" });
			_productList.Add(new ProductInfo { Code = "car", Description = "China" });

			RaisePropertyChanged("ComboBoxItemsSource");
		}
	}
}
