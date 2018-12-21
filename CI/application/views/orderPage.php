<!DOCTYPE html>
<html>
<head>
	<title>Customer Panel</title>
	<link content="text/css" href="<?php echo base_url();?>assets/CSS/design.css" rel="stylesheet" /> 
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
<div id="orderdata">
<font color="white" align="center">
<table border="2px">
	<tr>
		<th>Item Name</th>
		<th>Unit</th>
		<th>Price</th>
		<th>Quantity</th>
		<th> Click to Order </th>
	</tr>
	<tr>
		<?php foreach ($products as $product){?>
			<?php echo form_open('Order/addtoOrder');?>
			<td>
			<div class="name">
			<input type="text" value="<?php echo $product->Product_Name;?>" name="itemName" readonly>
			</div>
			</td>
			<td>
			<div class="size">
			<input type="text" value="<?php echo $product->Unit;?>" name="unit" readonly>
			</div>
			</td>
			<td>
			<div class="price">
			<input type="text" value="<?php echo $product->Sales_Price;?>" name="price" readonly>
			</div>
			</td>
			<td>
			<div class="qty">
			<input type="text" name="qty">
			</div>
			</td>
			<?php 
				echo form_hidden('id',$product->Product_Code);
			?>
			<td><center>
				<?php 
					echo form_submit('action','Order',['class'=>"btn btn-danger"]);
				?>
			</center></td>
				<?php 
					echo form_close();
				?>
		</tr>
		<?php }?>
</table>
</font>
</div>
</body>
</html>