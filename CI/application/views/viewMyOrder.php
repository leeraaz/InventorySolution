<!DOCTYPE html>
<html>
<head>
	<title>Customer Panel</title>
	<link content="text/css" href="<?php echo base_url();?>assets/CSS/design.css" rel="stylesheet" /> 
</head>
<body>
<div id="header">
	<center><img id="adminlogo" src="<?php echo base_url();?>assets/Images/customer.png" alt="adminlogo"><br>
	Customer Panel.
	</center>
</div>
<div id="sidebar">
	<ul>
		<li><a href="<?php echo base_url();?>PipeAndFittings/getItemforCustomer"> View items </a> </li>
		<li><a href="<?php echo base_url();?>Order/orderPage"> Place Order </a></li>
		<li><a href="<?php echo base_url();?>Order/viewMyOrders"> View Your Order </a></li>
		<li><a href="<?php echo base_url();?>customer/detailCustomer"> Update profile </a> </li>
		<li><a href="<?php echo base_url();?>customer/cusLogout"> Logout </a></li>
	</ul>
</div>
<div id="data">
<font color="white" size="4">
<center><h2> View Order </h2></center>
<table border="2" align="center">
<tr>
	<th> Order ID </th>
	<th> Customer ID </th>
	<th> Item Name </th>
	<th> Unit </th>
	<th> Quantity </th>
	<th> Delete </th>
</tr>
<?PHP
	foreach ($order as $row){ 
?>
<tr>
    <td><center> <?php echo $row->ORDER_ID; ?></center> </td>
	<td> <?php echo $row->CUSTOMER_ID; ?> </td>
	<td> <?php echo $row->ITEM_NAME; ?> </td>
	<td> <?php echo $row->Unit; ?> </td>
	<td> <?php echo $row->QUANTITY; ?> </td>
	<td> <?php echo anchor("owner/delStaff/", 'Delete' ,['class'=>"btn btn-danger"]);?> </td>
</tr>
<?php
}			
?>
</table>	
</font>
</div>
</body>
</html>