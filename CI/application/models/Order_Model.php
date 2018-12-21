<?php
	class Order_Model extends CI_Model{
		public function getProduct(){//for selcting pipe and fittings
			$result = $this->db->get('products')->result();
			return $result;
		}
		//for adding them into order list.
		public function get($itemID){
			$sql=$this->db->where('products',array('id'=>$itemID))->result();		
			return $sql;
		}
		//for displaying order
		public function orderDisplay(){
			$result = $this->db->get('orders')->result();
			return $result;
		}
	
		//for placing order
		public function placeOrder($sessionData,$itemName,$unit,$qty,$price){
				$array=array(
					"CUSTOMER_ID"=>$sessionData,	
					"ITEM_NAME"=>$itemName,
					"Unit"=>$unit,
					"QUANTITY"=>$qty,
					"PRICE"=>$price
				);
				$this->db->set('DATE', 'Now()', FALSE);
				$this->db->insert("orders",$array); 
				return "You have placed an order";		
		}
		
		public function orderList($STAFF_ID){
			$this->db->where('CUSTOMER_ID',$STAFF_ID);
			$sql=$this->db->get('orders');
			return $sql->result();
		}
	}
?>