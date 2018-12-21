<?php
	class Order extends CI_Controller{
		public function orderPage(){
			$this->load->model('Order_Model');
			$data['products'] = $this->Order_Model->getProduct();
			$this->load->view('orderPage',$data);
		}
		
		//for ordering an items available
		public function addtoOrder(){ 
			$sessionData = $this->session->userdata('CUSTOMER_ID');
			
			if ($sessionData != '') {
			$itemName=$this->input->POST("itemName");
			$unit=$this->input->POST("unit");
			$qty=$this->input->POST("qty");
			$price=$this->input->POST("price");
			
            $this->load->model('Order_Model');

            $this->Order_Model->placeOrder($sessionData,$itemName,$unit,$qty,$price);

            redirect (base_url(). 'Order/orderPage');
			} 
			else {
            echo "No any order has been made.";
			}
		}
		
		public function viewMyorders(){
		$STAFF_ID=$this->session->userdata('CUSTOMER_ID');
		$this->load->model('Order_Model');
		$dataStaff['order'] = $this->Order_Model->orderList($STAFF_ID);
		$this->load->view('viewMyOrder',$dataStaff);
		}
	}
?>