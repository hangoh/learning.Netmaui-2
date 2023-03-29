namespace paySplit;

public partial class MainPage : ContentPage
{
	int count = 0;
	double bill;
    double tip;

	public MainPage()
	{
		InitializeComponent();
	}

    void calculate_tip()
    {
        double b_a = double.Parse(total_bill.Text);
        double p = (int)tip_slider.Value / 100.00;
        double t = b_a * p;
        tip = Math.Round(t, 2);
        total_tip.Text = string.Format("{0:.00}", tip);
    }

    void calculate_bill_per_person()
    {
        double total_amount = bill + tip;
        double per_person = total_amount / int.Parse(person_count.Text);
        amount_to_pay.Text = string.Format("${0:.00}",Math.Round(per_person,2));
    }

    void bill_amount_Completed(System.Object sender, System.EventArgs e)
    {
		double b_a = double.Parse(bill_amount.Text);
		b_a = Math.Round(b_a, 2);
		bill = b_a;
		total_bill.Text = string.Format("{0:.00}", bill);
        calculate_tip();
        calculate_bill_per_person();
    }

    void ten_percent_tip_Clicked(System.Object sender, System.EventArgs e)
    {
        double b_a = double.Parse(total_bill.Text);
        double t = b_a * 0.1;
        tip = Math.Round(t, 2);
        total_tip.Text = string.Format("{0:.00}", tip);
        calculate_bill_per_person();
    }

    void fifteen_percent_tip_Clicked(System.Object sender, System.EventArgs e)
    {
        double b_a = double.Parse(total_bill.Text);
        double t = b_a * 0.15;
        tip = Math.Round(t, 2);
        total_tip.Text = string.Format("{0:.00}", tip);
        calculate_bill_per_person();
    }

    void twenty_percent_tip_Clicked(System.Object sender, System.EventArgs e)
    {
        double b_a = double.Parse(total_bill.Text);
        double t = b_a * 0.2;
        tip = Math.Round(t, 2);
        total_tip.Text = string.Format("{0:.00}", tip);
        calculate_bill_per_person();
    }

   

    void person_count_minus_Clicked(System.Object sender, System.EventArgs e)
    {
        int p = int.Parse(person_count.Text);
        
        if (p <= 1) {
            calculate_bill_per_person();
        }
        else {
            person_count.Text = string.Format("{0}", p - 1);
            calculate_bill_per_person();
            
        }
    }

    void person_count_plus_Clicked(System.Object sender, System.EventArgs e)
    {
        int p = int.Parse(person_count.Text);
        person_count.Text = string.Format("{0}", p + 1);
        calculate_bill_per_person();
    }

    void tip_slider_ValueChanged(System.Object sender, Microsoft.Maui.Controls.ValueChangedEventArgs e)
    {
        double b_a = double.Parse(total_bill.Text);
        double p = (int)tip_slider.Value / 100.00;
        double t = b_a * p;
        tip = Math.Round(t, 2);
        total_tip.Text = string.Format("{0:.00}", tip);
        tip_percentage.Text = string.Format("Tip: {0}%", (int)tip_slider.Value);
        calculate_bill_per_person();
    }
}


