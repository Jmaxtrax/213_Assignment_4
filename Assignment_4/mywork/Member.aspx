<%@ Page Title="" Language="C#" MasterPageFile="~/mywork/Site1.Master" AutoEventWireup="true" CodeBehind="Member.aspx.cs" Inherits="Assignment_4.mywork.Member" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container mt-5">
        <div class="row">
            <div class="col-md-12">
                <h2>Welcome, <asp:Label ID="lblMemberName" runat="server" Text=""></asp:Label>!</h2>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <h3>Payments History</h3>
                <form runat="server">
                    <asp:GridView ID="gvPayments" runat="server" AutoGenerateColumns="False" CssClass="table">
                        <Columns>
                            <asp:BoundField DataField="SectionName" HeaderText="Section Name" SortExpression="SectionName" />
                            <asp:BoundField DataField="InstructorFirstName" HeaderText="Instructor First Name" SortExpression="InstructorFirstName" />
                            <asp:BoundField DataField="InstructorLastName" HeaderText="Instructor Last Name" SortExpression="InstructorLastName" />
                            <asp:BoundField DataField="PaymentDate" HeaderText="Payment Date" SortExpression="PaymentDate" DataFormatString="{0:yyyy-MM-dd}" />
                            <asp:BoundField DataField="PaymentAmount" HeaderText="Payment Amount" SortExpression="PaymentAmount" DataFormatString="{0:C}" />
                        </Columns>
                    </asp:GridView>
                </form>
            </div>
        </div>
    </div>
</asp:Content>
