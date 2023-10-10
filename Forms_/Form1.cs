using Application.Features.Items.Queries.GetListStockExtract;
using MediatR;
using Microsoft.AspNetCore.Http;
using Persistence.Repositories;
using System.Net.Http;

namespace Forms_
{
    public partial class Form1 : Form
    {
        //private IMediator? _mediator;
        //protected IMediator? Mediator => _mediator ??=
        //    HttpContext.RequestServices.GetService<IMediator>();

        public Form1()
        {
            InitializeComponent();
        }

        private async void btnGetData_Click(object sender, EventArgs e)
        {
            //GetListStockExtractQuery searchData = new GetListStockExtractQuery()
            //{
            //    StartDate = btnStartDate.Text.ToString(),
            //    EndDate = btnEndDate.Text.ToString(),
            //    ProductCode = btnProductCode.Text.ToString(),
            //};

        }
    }
}