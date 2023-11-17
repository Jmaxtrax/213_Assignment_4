<%@ Page Title="" Language="C#" MasterPageFile="~/mywork/Site1.Master" AutoEventWireup="true" CodeBehind="Administrator.aspx.cs" Inherits="Assignment_4.mywork.Administrator" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <form id="FormId" runat="server">
        <div class="container mt-5">
            <div class="row">
                <div class="col-md-12">
                    <p>&nbsp;</p>
                    <h2>Member Information</h2>
                    <p>
                        <asp:GridView ID="gvMember" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" AutoGenerateSelectButton="True">
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
                        <asp:Button ID="btnDeleteMember" runat="server" Text="Delete Selected Member" />
                    </p>
                    <p>
                        &nbsp;</p>
                </div>
            </div>
            <div class="row mt-4">
                <div class="col-md-12">
                    <h2>Instructor Information</h2>
                    <asp:GridView ID="gvInstructor" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" AutoGenerateSelectButton="True">
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
                    <asp:Button ID="btnDeleteInstructor" runat="server" Text="Delete Selected Instructor" />
                </div>
            </div>
            <div class="row mt-4">
                <div class="col-md-12">
                    <h2>Actions</h2>
                    <h3>Add new Member</h3>
                    <p>UserID:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="txtBxAddMemberUserID" runat="server"></asp:TextBox>
                    </p>
                    <p>Username:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
                        <asp:TextBox ID="txtBxAddMemberUsername" runat="server"></asp:TextBox>
                    </p>
                    <p>Password:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
                        <asp:TextBox ID="txtBxAddMemberPassword" runat="server"></asp:TextBox>
                    </p>
                    <p>First Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                        <asp:TextBox ID="txtBxAddMemberFirstName" runat="server"></asp:TextBox>
                    </p>
                    <p>Last Name:&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="txtBxAddMemberLastName" runat="server"></asp:TextBox>
                    </p>
                    <p>Phone Number:&nbsp;
                        <asp:TextBox ID="txtBxAddMemberPhone" runat="server"></asp:TextBox>
                    </p>
                    <p>Email:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                        <asp:TextBox ID="txtBxAddMemberEmail" runat="server"></asp:TextBox>
                    </p>
                    <p>
                        <asp:Button ID="btnAddMember" runat="server" Text="Add Member" />
                    </p>
                    <h3>Add new Instructor</h3>
                    <p>UserID:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="txtBxAddInstructorUserID" runat="server"></asp:TextBox>
                    </p>
                    <p>Username:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                        <asp:TextBox ID="txtBxAddInstructorUsername" runat="server"></asp:TextBox>
                    </p>
                    <p>Password:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp;
                        <asp:TextBox ID="txtBxAddInstructorPassword" runat="server"></asp:TextBox>
                    </p>
                    <p>First Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="txtBxAddInstructorFirstName" runat="server"></asp:TextBox>
                    </p>
                    <p>Last Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="txtBxAddInstructorLastName" runat="server"></asp:TextBox>
                    </p>
                    <p>Phone Number:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="txtBxAddInstructorPhone" runat="server"></asp:TextBox>
                    </p>
                    <p>
                        <asp:Button ID="btnAddInstructor" runat="server" Text="Add Instructor" />
                    </p>
                    <h3>Assign Member to Section</h3>
                    <p>Section:&nbsp;&nbsp;
                        <asp:DropDownList ID="ddlSection" runat="server">
                            <asp:ListItem>Karate Age-Uke</asp:ListItem>
                            <asp:ListItem>Karate Chudan-Uke</asp:ListItem>
                        </asp:DropDownList>
                    </p>
                    <p>Member:
                        <asp:DropDownList ID="ddlMember" runat="server">
                        </asp:DropDownList>
                    </p>
                    <p>
                        <asp:Button ID="btnAssignMember" runat="server" Text="Assign" />
                    </p>
                    <!-- Add controls for adding, deleting, and assigning members to sections -->
                </div>
            </div>
        </div>
    </form>
</asp:Content>
