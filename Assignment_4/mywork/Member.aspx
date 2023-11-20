<%@ Page Title="" Language="C#" MasterPageFile="~/mywork/Site1.Master" AutoEventWireup="true" CodeBehind="Member.aspx.cs" Inherits="Assignment_4.mywork.Member" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            font-size: medium;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container mt-5">
        <div class="row">
            <div class="col-md-12">
                <form runat="server">
                    <h2>
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Logout" Height="40px" Width="131px" CssClass="auto-style1" />
                    </h2>
                    <h2>Welcome,
                    <asp:Label ID="lblMemberName" runat="server" Text=""></asp:Label>!</h2>
                    <asp:GridView ID="gvMember" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical">
                        <AlternatingRowStyle BackColor="#DCDCDC" />
                        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                        <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                        <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                        <SortedAscendingHeaderStyle BackColor="#0000A9" />
                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                        <SortedDescendingHeaderStyle BackColor="#000065" />
                    </asp:GridView>
                    <h2>Total Cost:
                        <asp:Label ID="lblTotalCost" runat="server"></asp:Label>
                    </h2>
                </form>
            </div>
        </div>
    </div>
</asp:Content>
