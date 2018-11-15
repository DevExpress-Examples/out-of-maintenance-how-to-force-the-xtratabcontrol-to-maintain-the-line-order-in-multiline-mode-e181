<!-- default file list -->
*Files to look at*:

* [MyXtraTabControl.cs](./CS/Q147080/MyXtraTabControl.cs) (VB: [MyXtraTabControl.vb](./VB/Q147080/MyXtraTabControl.vb))
<!-- default file list end -->
# How to force the XtraTabControl to maintain the line order in MultiLine mode


<p>When the XtraTabControl is used in MultiLine mode, it automatically moves the currently selected line to the last position. This example demonstrates how to change this behavior by registering custom paint styles.</p>


<h3>Description</h3>

<p>To disable the default functionality, override the BaseTabRowViewInfoCollection.MakeSelectedRowLast method, and simply leave it empty:</p><code lang='cs'>
public override void MakeSelectedRowLast() { }
</code><p>Please review the sample project for more information on how to register custom View Info for the XtraTabControl.</p>

<br/>


