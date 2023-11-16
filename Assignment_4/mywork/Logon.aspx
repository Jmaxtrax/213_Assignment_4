<%@ Page Title="" Language="C#" MasterPageFile="~/mywork/Site1.Master" AutoEventWireup="true" CodeBehind="Logon.aspx.cs" Inherits="Assignment_4.mywork.Logon" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container mt-5">
        <div class="row justify-content-center">
            <div class="col-md-6">
                <div class="card">
                    <div class="card-body">
                        <h2 class="card-title text-center">Login</h2>
                        <form runat="server" method="post">
                            <div class="mb-3">
                                <label for="txtUsername" class="form-label">Username:</label>
                                <input type="text" id="txtUsername" runat="server" class="form-control" />
                            </div>
                            <div class="mb-3">
                                <label for="txtPassword" class="form-label">Password:</label>
                                <input type="password" id="txtPassword" runat="server" class="form-control" />
                            </div>
                            <div class="d-grid gap-2">
                                <button type="submit" class="btn btn-primary">Login</button>
                            </div>
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
