<!DOCTYPE html>
<html>
<head>
	<title>Customer Panel</title>
	<link content="text/css" href="<?php echo base_url();?>assets/CSS/design.css" rel="stylesheet" /> 
	<link href="<?php echo base_url();?>assets/CSS/bootstrap.min.css" rel="stylesheet" content="text/css" />
</head>
<body>
<div id="header">
	<center><img id="adminlogo" src="<?php echo base_url();?>assets/Images/customer.png" alt="adminlogo"><br>
	Customer PANEL.</br>
	<?php
		echo 'Welcome - '.$this->session->userdata('USERNAME').' and your customer ID is.'.$this->session->userdata('CUSTOMER_ID');
	?>
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
<center><h2> Pipe and Fittings available right now</h2></center>
<table border="2" align="center">
<tr>
	<th> ID </th>
	<th> Item Name </th>
	<th>Unit </th>
	<th> Quantity </th>
	<th> Selling Price </th>
</tr>
<?PHP
	 foreach ($items as $product)

{ ?>
<tr>
    <td><center> <?php echo $product->Product_Code; ?></center> </td>
	<td> <?php echo $product->Product_Name; ?> </td>
	<td> <?php echo $product->Unit; ?> </td>
	<td> <?php echo $product->Quantity; ?> </td>
	<td> <?php echo $product->Sales_Price; ?> </td>
</tr>
<?php
 }			
?>
</table>
</div>
</body>
</html>