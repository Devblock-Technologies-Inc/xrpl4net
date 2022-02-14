# xrpl4net
.NET library to interact with XRPL written in C#

# Project details

The repo is divided into 3 sub-projects:

- Client - Library which wraps around the functionality to communicate with XRPL.
- Tests - E2E tests to test the library
- Web Demo - A demo application which consumes the library to demonstrate the functionalities.

# XrplClient

Client library exposes methods to perform the following operations - 

- Manage accounts/wallets
- Connect to the server (testnet by default)
- Prepare, sign and submit a transaction
- Check the status of a transaction

# Demo Set up 

To run the demo , use visual studio and run the project "xrpl4net.application.demo". 
The application will start in the default browser to explore the functionality of the library.
