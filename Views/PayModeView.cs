﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_mvp.Views
{
    
    public partial class PayModeView : Form, IPayModeView
    {
        private bool isEdit;
        private bool isSeccessful;
        private string message;

        //constructor
        public PayModeView()
        {
            InitializeComponent();
        }
        //eventos
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEven;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEven;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        //metodos 
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void PayModeView_Load(object sender, EventArgs e)
        {

        }
        public void show()
        {
            throw new NotImplementedException();
        }

        public void SetPayModeListBildingsource(BindingSource payModeList)
        {
            DgPayMode.DataSource = payModeList;
        }
        public string PayModeId
        {
            get { return TxtPayModeId.Text; }
            set { TxtPayModeId.Text = value; }
        }

        public string PayModeName
        {
            get { return TxtPayModeName.Text; }
            set { TxtPayModeName.Text = value; }
        }

        public string PayModeObservation
        {
            get { return TxtPayModeObservation.Text; }
            set { TxtPayModeObservation.Text = value; }
        }
        public string SearchValue
        {
            get { return TxtSearch.Text; }
            set { TxtSearch.Text = value; }

        }
        public bool IsEdit
        {
            get { return isEdit; }
            set { isEdit = value; }
        }
        public bool IsSeccessful
        {
            get { return isSeccessful; }
            set { isSeccessful = value; }
        }
        
        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public string SearchaValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsSuccessful { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        private void AssociateAnRaiseViewEvents()
        {
            BtnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            TxtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };
        }
        public PayModeView()
        {
            InitializeComponent();
            AssociateAnRaiseViewEvents();

            tabControl.TabPages.Remove(tabPagePayModeDetail.PayModeDetail);
        }
    }
    
}
