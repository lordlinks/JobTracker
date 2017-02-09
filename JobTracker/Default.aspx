<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="JobTracker._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>JobTracker</h1>
    </div>
    <div class="row">
        <h2>Create entry</h2>
    </div>
    <div class="row">
        <div class="col-md-6">
            <h2>Add New</h2>
            <div class="form-group">
                <label for="Bname">Business Name:</label>
                <input id="Bname" class="form-control" type="text" runat="server" />
            </div>
            <div class="form-group">
                <label for="Tel">Contact Name:</label>
                <input id="Tel" class="form-control" type="tel" runat="server" />
            </div>
            <div class="form-group">
                <label for="Job">Job Title:</label>
                <input id="Job" class="from-control" type="text" runat="server" />
            </div>
            <div>
                <button class="btn btn-primary" type="button" onserverclick="add_new">Submit</button>
            </div>
        </div>
        <div class="col-md-6">
            <h2>Application information</h2>
            <div class="form-group">
                <label for="Where">How did you find the job?</label>
                <input id="Where" class="form-control" type="text" />
                <button class="btn btn-primary" type="button" onserverclick="Where1">Update</button>
            </div>
            <div class="form-group">
                <label for="Method">Method of contact:</label>
                <input id="Method" type="text" />
                <button class="btn btn-primary" type="button" onserverclick="Method1">Update</button>
            </div>
        </div>
    </div>

</asp:Content>
