# SCRAPE2COMPARE- Loan Prediction Desktop Application: 
Home Loan estimating tool designed to help veterans compare rates and understand monthly payments.
This Windows form application have 3 funcitons to serve user cuiousity about a home Loan:

1. Scrape: Scrape2Compare scrapes website of 3 of the top VA Lenders(According to Google) and displays in one window for seamless comparision. User has ability to store rates on a local file on user's computer to keep track of changes to rate from indivdual banks. 
2. Compare: Scrape2Compare allows you to select the best interest rates from scrape tab or a custom rate to play with and compare. This section had a feature for allowing user to move a slidebar to see where user stands during specific time in a loan period.
3. Predict: Scrape2Compare uses Machine learing with a custom dataset to predict if user will qualify for loan depending on inputs. It also provides suggestions on what could user do to improve chances of approval.

Note: This windows application is an estimating tool only and all these features are performed within this application; Although scrape feature extracts rates from lender website in real time, using Predict feature for this application will not qualify/ disqualify you from a loan. The intrest rate displayed on Scrape section is the best rate Lenders are advertizing for certain conditions.

Technology used:

IDE: Visual Studio,
Programing language: C#,
Application classification: Windows Form,
Experimented: Webscraping using C# and ML.NET.

I am using clustering machine learning model to predict result using dataset from a txt file with data seperated with comas. Clustering plots graph of data from the data sets and identifies which cluster user entered values is the most close to. For this problem I am using 3 clusters- low ,medium and high for approval odds.  

Welcome frame of Application:

![s2cHome](https://user-images.githubusercontent.com/84284851/122705396-7c30a200-d20a-11eb-8101-de7836d2a6a4.jpg)

Scrape Tab:

![scrape_tab](https://user-images.githubusercontent.com/84284851/123878527-1328e880-d8f4-11eb-807e-a7d4698c79dd.jpg)

Compare Tab:

![compare_tab](https://user-images.githubusercontent.com/84284851/123878553-2045d780-d8f4-11eb-945c-92dbe033f58e.jpg)

Predict Tab with three possible results:

![predict_medium](https://user-images.githubusercontent.com/84284851/123878589-2fc52080-d8f4-11eb-8eac-91a4e0782e83.jpg)
![predict_high](https://user-images.githubusercontent.com/84284851/123878591-305db700-d8f4-11eb-9149-3a6bc4d52ff5.jpg)
![predict_low](https://user-images.githubusercontent.com/84284851/123878592-305db700-d8f4-11eb-9700-344a5fb39c9f.jpg)



