<%@ Page Title="" Language="C#" MasterPageFile="~/mywork/Site1.Master" AutoEventWireup="true" CodeBehind="Administrator.aspx.cs" Inherits="Assignment_4.mywork.Administrator" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container mt-5">
        <div class="row">
            <div class="col-md-12">
                <h2>Member Information</h2>
                <asp:GridView ID="gvMembers" runat="server" AutoGenerateColumns="False" CssClass="table table-striped table-bordered">
                    <HeaderStyle CssClass="thead-light" />
                    <Columns>
                        <asp:BoundField DataField="MemberFirstName" HeaderText="First Name" SortExpression="MemberFirstName" />
                        <asp:BoundField DataField="MemberLastName" HeaderText="Last Name" SortExpression="MemberLastName" />
                        <asp:BoundField DataField="MemberPhoneNumber" HeaderText="Phone Number" SortExpression="MemberPhoneNumber" />
                        <asp:BoundField DataField="MemberDateJoined" HeaderText="Date Joined" SortExpression="MemberDateJoined" DataFormatString="{0:yyyy-MM-dd}" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
        <div class="row mt-4">
            <div class="col-md-12">
                <h2>Instructor Information</h2>
                <asp:GridView ID="gvInstructors" runat="server" AutoGenerateColumns="False" CssClass="table table-striped table-bordered">
                    <HeaderStyle CssClass="thead-light" />
                    <Columns>
                        <asp:BoundField DataField="InstructorFirstName" HeaderText="First Name" SortExpression="InstructorFirstName" />
                        <asp:BoundField DataField="InstructorLastName" HeaderText="Last Name" SortExpression="InstructorLastName" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
        <div class="row mt-4">
            <div class="col-md-12">
                <h2>Actions</h2>
                <!-- Add controls for adding, deleting, and assigning members to sections -->
            </div>
        </div>
    </div>
</asp:Content>
