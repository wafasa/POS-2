﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using POS.BusinessLayer;
using POS.BusinessLayer.Wrapper;

namespace POS.UserInterfaceLayer.BasicData
{
    public partial class frmProductGroupSearch : POS.UserInterfaceLayer.Portal.frmBaseSearchForm
    {
        private BDProductGroupWrapper _bdProductGroupWrapper = new BDProductGroupWrapper();

        public frmProductGroupSearch()
        {
            InitiateGrid();
            InitializeComponent();
            base.lbl_FormHeader.Text = "بحث";
        }

        public void InitiateGrid()
        {
            dgrid_Result.Columns.Clear();

            dgrid_Result.AutoGenerateColumns = false;

            dgrid_Result.Height = 150;

            dgrid_Result.Size = new Size(10, 250);

            List<BDProductGroup> ProductGroup = _bdProductGroupWrapper.SelectAll();

            dgrid_Result.DataSource = ProductGroup;

            addColumnToGrid("ProductGroupID", "ProductGroupID", 120, false);
            addColumnToGrid("إسم المجموعة", "ProductGroupName", 120, true);
        }

        /// <summary>
        /// Events Override
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public override void btn_Add_Click(object sender, EventArgs e)
        {
            frmProductGroupAddEdit frm = new frmProductGroupAddEdit(this);
            frm.ShowDialog();
        }
        public override void btn_Edit_Click(object sender, EventArgs e)
        {
            int productGroupID = 0;
            if (dgrid_Result.Rows[dgrid_Result.SelectedCells[0].RowIndex].Cells["ProductGroupID"].Value != null)
            {
                productGroupID = Convert.ToInt32(dgrid_Result.Rows[dgrid_Result.SelectedCells[0].RowIndex].Cells["ProductGroupID"].Value);
            }
            else
            {
                MessageBox.Show("لابد من اختيار مجموعة");
            }
            frmProductGroupAddEdit frm = new frmProductGroupAddEdit(productGroupID,this);
            frm.ShowDialog();
        
        
        }
        public override void btn_Delete_Click(object sender, EventArgs e) { }
        public override void btn_Back_Click(object sender, EventArgs e) { }
    }
}
