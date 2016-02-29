# wmvn-merchant-csharp
Webmoney Vietnam Merchant C# Sample Code

Đây là thư viện sample code để tích hợp giao tiếp với cổng thanh toán Webmoney Merchant API, dành cho các đối tác của Webmoney Vietnam

Yêu cầu
------------
- .NET Framework 4.5.2

Hướng dẫn sử dụng
-----------------------
Build project WM.Merchant. Add reference vào project web của bạn 
Thư viện sẽ yêu cầu một số thông tin chứng thực API, bao gồm MerchantCode, Passcode và Secret Key, được cung cấp bởi Webmoney 

Thêm và chỉnh sửa một số thông tin trong Web.config

```csharp

<configuration>
  	<configSections>
    	...
    	<section name="wmMerchant" type="WM.Merchant.MerchantConfiguration" />
  	</configSections>
	...
	<wmMerchant>
    	<wmService merchantCode="YOUR MERCHANT CODE" passcode="YOUR PASSCODE" secretKey="YOUR SECRET KEY" productionMode="false" />
  	</wmMerchant>
<configuration>
```
