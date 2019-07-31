﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InstanceItem.aspx.cs" Inherits="AspNetWebFormsApp.Views.DICOMMenu.InstanceItem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="col-xs-6 col-sm-4 col-md-3">
            <div class="panel-body thumbnail">
                <div class="xcol-md-3">
                    <strong><span>Instance Number:</span></strong>
                    <strong><span data-pacs-instancenum="true"></span></strong>
                </div>
            </div>

            <div class="panel-footer">
                <div class="btn-group btn-group-justified" role="group">
                    <div class="btn-group">
                        <a href="#" type="button" role="button" data-pacs-viewinstanceviewer class="btn btn-default btn-sm">View</a>
                    </div>
                    <div class="btn-group dropup">
                        <a href="#" type="button" role="button" class="btn btn-default btn-sm dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">More...
                    <span class="caret"></span>
                        </a>
                        <ul class="dropdown-menu">
                            <li><a href="#" data-rs-instance data-pacs-args="application/dicom">WADO-RS Instance<i class="pull-right glyphicon glyphicon-save"></i></a></li>
                            <li><a href="#" data-rs-instance data-pacs-args="application/octet-stream">WADO-RS Bulk-data<i class=" pull-right glyphicon glyphicon-save"></i></a></li>
                            <li role="separator" class="divider"></li>
                            <li><a href="#" data-pacs-instance-json>WADO-RS-Meta (JSON)</a></li>
                            <li><a href="#" data-pacs-instance-xml>WADO-RS-Meta (XML)</a></li>
                            <li role="separator" class="divider"></li>
                            <li><a href="#" data-pacs-viewqidoinstance="json">QIDO-RS (JSON)</a></li>
                            <li><a href="#" data-pacs-viewqidoinstance="xml">QIDO-RS (XML)</a></li>
                        </ul>
                    </div>
                </div>
            </div>

        </div>
    </form>
</body>
</html>
