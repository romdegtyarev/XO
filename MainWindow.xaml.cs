using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Drawing;

namespace Game {
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow( ) {
			InitializeComponent( );
			
		}
		//Varibles
		string enter = "X";
		string name = null;
		int scoreX = 0;
		int scoreZ = 0;
		/*
		====================
		Play

			Play
		====================
		*/
		public void Play( ) {
			textBlock.Text = enter + " turning";
			textBox.IsEnabled = false;
			textBox1.IsEnabled = false;
			button.IsEnabled = true;
			button.Content = "";
			button1.Content = "";
			button2.Content = "";
			button3.Content = "";
			button4.Content = "";
			button5.Content = "";
			button6.Content = "";
			button7.Content = "";
			button8.Content = "";
			button1.IsEnabled = true;
			button2.IsEnabled = true;
			button3.IsEnabled = true;
			button4.IsEnabled = true;
			button5.IsEnabled = true;
			button6.IsEnabled = true;
			button7.IsEnabled = true;
			button8.IsEnabled = true;
			button9.Visibility = ( Visibility )0;
			button10.Visibility = ( Visibility )1;
		}
		/*
		====================
		Start

			Start
		====================
		*/
		public void Start(  ) {
			textBlock.Text = "Ener your name";
			scoreX = 0;
			scoreZ = 0;
			textBlock5.Text = scoreX.ToString( );
			textBlock6.Text = scoreZ.ToString( );
			textBox.IsEnabled = true;
			textBox1.IsEnabled = true;
			button.IsEnabled = false;
			button1.IsEnabled = false;
			button2.IsEnabled = false;
			button3.IsEnabled = false;
			button4.IsEnabled = false;
			button5.IsEnabled = false;
			button6.IsEnabled = false;
			button7.IsEnabled = false;
			button8.IsEnabled = false;
			button.Content = "";
			button1.Content = "";
			button2.Content = "";
			button3.Content = "";
			button4.Content = "";
			button5.Content = "";
			button6.Content = "";
			button7.Content = "";
			button8.Content = "";
			button10.Visibility = ( Visibility )0;
		}
		/*
		====================
		Inspection

			Inspection
		====================
		*/
		public int Inspection (  ) {
			if ( enter == "X" ) {
				name = textBox.Text;
			}
			if ( enter == "0" ) {
				name = textBox1.Text;
			}
			//Horizontal
			if ( button.Content == button1.Content && button.Content == button2.Content && (string)(button.Content) == enter ) {
				textBlock.Text = enter + " (" + name + ") is Win";
				
				if ( enter == "X" ) {
					scoreX ++;
					textBlock5.Text = scoreX.ToString( );
				}
				if ( enter == "0" ) {
					scoreZ ++;
					textBlock6.Text = scoreZ.ToString( );
				}
				button3.IsEnabled = false;
				button4.IsEnabled = false;
				button5.IsEnabled = false;
				button6.IsEnabled = false;
				button7.IsEnabled = false;
				button8.IsEnabled = false;
				button11.Visibility = ( Visibility )0;
				return 1;
			}
			if ( button3.Content == button4.Content && button3.Content == button5.Content && ( string )( button3.Content ) == enter ) {
				textBlock.Text = enter + " (" + name + ") is Win";
				
				if ( enter == "X" ) {
					scoreX++;
					textBlock5.Text = scoreX.ToString( );
				}
				if ( enter == "0" ) {
					scoreZ++;
					textBlock6.Text = scoreZ.ToString( );
				}
				button.IsEnabled = false;
				button1.IsEnabled = false;
				button2.IsEnabled = false;
				button6.IsEnabled = false;
				button7.IsEnabled = false;
				button8.IsEnabled = false;
				button11.Visibility = ( Visibility )0;
				return 1;
			}
			if ( button6.Content == button7.Content && button6.Content == button8.Content && ( string )( button6.Content ) == enter ) {
				textBlock.Text = enter + " (" + name + ") is Win";
				
				if ( enter == "X" ) {
					scoreX++;
					textBlock5.Text = scoreX.ToString( );
				}
				if ( enter == "0" ) {
					scoreZ++;
					textBlock6.Text = scoreZ.ToString( );
				}
				button.IsEnabled = false;
				button1.IsEnabled = false;
				button2.IsEnabled = false;
				button3.IsEnabled = false;
				button4.IsEnabled = false;
				button5.IsEnabled = false;
				button11.Visibility = ( Visibility )0;
				return 1;
			}
			//Vertical
			if ( button.Content == button3.Content && button.Content == button6.Content && ( string )( button.Content ) == enter ) {
				textBlock.Text = enter + " (" + name + ") is Win";
				
				if ( enter == "X" ) {
					scoreX++;
					textBlock5.Text = scoreX.ToString( );
				}
				if ( enter == "0" ) {
					scoreZ++;
					textBlock6.Text = scoreZ.ToString( );
				}
				button1.IsEnabled = false;
				button2.IsEnabled = false;
				button4.IsEnabled = false;
				button5.IsEnabled = false;
				button7.IsEnabled = false;
				button8.IsEnabled = false;
				button11.Visibility = ( Visibility )0;
				return 1;
			}
			if ( button1.Content == button4.Content && button1.Content == button7.Content && ( string )( button1.Content ) == enter ) {
				textBlock.Text = enter + " (" + name + ") is Win";
				
				if ( enter == "X" ) {
					scoreX++;
					textBlock5.Text = scoreX.ToString( );
				}
				if ( enter == "0" ) {
					scoreZ++;
					textBlock6.Text = scoreZ.ToString( );
				}
				button.IsEnabled = false;
				button2.IsEnabled = false;
				button3.IsEnabled = false;
				button5.IsEnabled = false;
				button6.IsEnabled = false;
				button8.IsEnabled = false;
				button11.Visibility = ( Visibility )0;
				return 1;
			}
			if ( button2.Content == button5.Content && button2.Content == button8.Content && ( string )( button2.Content ) == enter ) {
				textBlock.Text = enter + " (" + name + ") is Win";
				
				if ( enter == "X" ) {
					scoreX++;
					textBlock5.Text = scoreX.ToString( );
				}
				if ( enter == "0" ) {
					scoreZ++;
					textBlock6.Text = scoreZ.ToString( );
				}
				button.IsEnabled = false;
				button1.IsEnabled = false;
				button3.IsEnabled = false;
				button4.IsEnabled = false;
				button6.IsEnabled = false;
				button7.IsEnabled = false;
				button11.Visibility = ( Visibility )0;
				return 1;
			}
			//Diagonal
			if ( button.Content == button4.Content && button.Content == button8.Content && ( string )( button.Content ) == enter ) {
				textBlock.Text = enter + " (" + name + ") is Win";
				
				if ( enter == "X" ) {
					scoreX++;
					textBlock5.Text = scoreX.ToString( );
				}
				if ( enter == "0" ) {
					scoreZ++;
					textBlock6.Text = scoreZ.ToString( );
				}
				button1.IsEnabled = false;
				button2.IsEnabled = false;
				button3.IsEnabled = false;
				button5.IsEnabled = false;
				button6.IsEnabled = false;
				button7.IsEnabled = false;
				button11.Visibility = ( Visibility )0;
				return 1;
			}
			if ( button2.Content == button4.Content && button2.Content == button6.Content && ( string )( button2.Content ) == enter ) {
				textBlock.Text = enter + " (" + name + ") is Win";
				
				if ( enter == "X" ) {
					scoreX++;
					textBlock5.Text = scoreX.ToString( );
				}
				if ( enter == "0" ) {
					scoreZ++;
					textBlock6.Text = scoreZ.ToString( );
				}
				button.IsEnabled = false;
				button1.IsEnabled = false;
				button3.IsEnabled = false;
				button5.IsEnabled = false;
				button7.IsEnabled = false;
				button8.IsEnabled = false;
				button11.Visibility = ( Visibility )0;
				return 1;
			} else {
				return 0;
			}
		}
		/*
		====================
		Click Treatment

			Click Treatment
		====================
		*/
		public void Write( Button button ) {
			button.Content = enter;
			
			if ( ( string )( button.Content ) == enter ) {
				button.IsEnabled = false;
			}
			if ( Inspection( )!=1 ) {
				if ( enter == "X" ) {
					enter = "0";
					textBlock.Text = enter + " turning";
				} else {
					enter = "X";
					textBlock.Text = enter + " turning";
				}
			}
		}
		/*
		====================
		Button Click

			Button Click
		====================
		*/
		private void button_Click( object sender, RoutedEventArgs e ) {
			Write( button );
		
		}
		private void button1_Click( object sender, RoutedEventArgs e ) {
			Write( button1 );
			
		}
		private void button2_Click( object sender, RoutedEventArgs e ) {
			Write( button2 );
			
		}
		private void button3_Click( object sender, RoutedEventArgs e ) {
			Write( button3 );
			
		}
		private void button4_Click( object sender, RoutedEventArgs e ) {
			Write( button4 );
			
		}
		private void button5_Click( object sender, RoutedEventArgs e ) {
			Write( button5 );
			
		}
		private void button6_Click( object sender, RoutedEventArgs e ) {
			Write( button6 );
			
		}
		private void button7_Click( object sender, RoutedEventArgs e ) {
			Write( button7 );
			
		}
		private void button8_Click( object sender, RoutedEventArgs e ) {
			Write( button8 );
			
		}
		/*
		====================
		Button Click

			Button Click
		====================
		*/
		private void button9_Click( object sender, RoutedEventArgs e ) {
			Start( );
		}
		private void button10_Click( object sender, RoutedEventArgs e ) {
			Play( );
		}

		private void button11_Click( object sender, RoutedEventArgs e ) {
			//Start( );
			Play( );
			button11.Visibility = ( Visibility )1;
		}
	}
}
