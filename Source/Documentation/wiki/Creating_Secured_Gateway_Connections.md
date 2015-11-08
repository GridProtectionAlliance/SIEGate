<html lang="en">
<head>
</head>
<body>
<!--HtmlToGmd.Body-->
<div id="NavigationMenu">
<h1><a href="https://github.com/ajstadlin/SIEGate/blob/master/Source/Documentation/wiki/SIEGate.md">
<img src="https://github.com/ajstadlin/SIEGate/blob/master/Source/Documentation/wiki/SIEGate_Logo.png" alt="SIEGate" /></a></h1>
<hr />
<table style="width: 100%; border-collapse: collapse; border: 0px solid gray;">
<tr>
<td style="width: 25%; text-align:center;"><b><a href="http://www.gridprotectionalliance.com">Grid Protection Alliance</a></b></td>
<td style="width: 25%; text-align:center;"><b><a href="https://github.com/ajstadlin/SIEGate">SIEGate Project on GitHub</a></b></td>
<td style="width: 25%; text-align:center;"><b><a href="https://github.com/ajstadlin/SIEGate/blob/master/Source/Documentation/wiki/SIEGate.md">SIEGate Wiki</a></b></td>
<td style="width: 25%; text-align:center;"><b><a href="https://github.com/ajstadlin/SIEGate/blob/master/Source/Documentation/wiki/SIEGate_Documentation.md">SIEGate Documentation</a></b></td>
</tr>
</table>
</div>
<hr />
<!--/HtmlToGmd.Body-->

<div class="WikiContent">

                
<div class="wikidoc">SIEGate to SIEGate connections can be made using Transport Layer Security, a highly-secure channel.
<br>
<br>
In this demonstration setup, we have a SIEGate installation (<span class="codeInline">DEMO01SIEGATE</span>) which is receiving data, and a second SIEGate (<span class="codeInline">DEMO02SIEGATE</span>) which we want to share with. A bidirectional connection
 will be created, and measurements will be authorised and subscribed.<br>
<br>
We&#39;ll start with SIEGate on system 2, the system that does not have data. In the menu, click on &#39;Subscription&#39; -&gt; &#39;Create Authorization Request&#39;<br>
<br>
<img src="https://github.com/ajstadlin/SIEGate/blob/master/Source/Documentation/wiki/Creating_Secured_Gateway_Connections.files/01.png" alt="01.png" title="01.png"><br>
<br>
There are three sections we need to fill out; Publisher information, Subscriber information, and TLS.
<br>
<br>
In this case, <span class="codeInline">DEMO01SIEGATE</span> is the publisher. We&#39;ll fill in the publisher section as follows:<br>
<br>
<img src="https://github.com/ajstadlin/SIEGate/blob/master/Source/Documentation/wiki/Creating_Secured_Gateway_Connections.files/03-pub.png" alt="03-pub.png" title="03-pub.png"><br>
<br>
This SIEGate, <span class="codeInline">DEMO02SIEGATE</span>, is the subscriber.
<br>
<br>
<img src="https://github.com/ajstadlin/SIEGate/blob/master/Source/Documentation/wiki/Creating_Secured_Gateway_Connections.files/03-sub.png" alt="03-sub.png" title="03-sub.png"><br>
<br>
In the TLS section, SIEGate has already filled out the name of the certificate file needed to establish the connection. At this point, we have not yet received this certificate; that will come in later. Right now, we only need to check the &#39;Self-signed&#39;
 checkbox. (If you are getting a cert from trusted CA, these steps would be different. This is assuming you&#39;re using the default certificates that were generated when you installed SIEGate)<br>
<br>
<img src="https://github.com/ajstadlin/SIEGate/blob/master/Source/Documentation/wiki/Creating_Secured_Gateway_Connections.files/03-tls.png" alt="03-tls.png" title="03-tls.png"><br>
<br>
All together, our settings look like this.<br>
<br>
<img src="https://github.com/ajstadlin/SIEGate/blob/master/Source/Documentation/wiki/Creating_Secured_Gateway_Connections.files/04.png" alt="04.png" title="04.png"><br>
<br>
Once we click create, we&#39;re prompted to save our Subscription Request. You&#39;ll need to get this file to the publisher in a secure manner; this file will allow them to verify you are you.
<br>
<br>
After we&#39;ve saved the request, the device configuration screen is presented. <br>
<br>
<img src="https://github.com/ajstadlin/SIEGate/blob/master/Source/Documentation/wiki/Creating_Secured_Gateway_Connections.files/05.png" alt="05.png" title="05.png"><br>
<br>
Next, we need to switch over to the publisher, <span class="codeInline">DEMO01SIEGATE</span>.
<br>
<br>
On the publisher, click &#39;Publication&#39; -&gt; &#39;Authorize Subscribers&#39;.<br>
<br>
<img src="https://github.com/ajstadlin/SIEGate/blob/master/Source/Documentation/wiki/Creating_Secured_Gateway_Connections.files/10.png" alt="10.png" title="10.png"><br>
<br>
On this screen, we&#39;ll click &#39;Import SRQ&#39; to load the authorization request from the subscriber<br>
<br>
<img src="https://github.com/ajstadlin/SIEGate/blob/master/Source/Documentation/wiki/Creating_Secured_Gateway_Connections.files/11.png" alt="11.png" title="11.png"><br>
<br>
<img src="https://github.com/ajstadlin/SIEGate/blob/master/Source/Documentation/wiki/Creating_Secured_Gateway_Connections.files/12.png" alt="12.png" title="12.png"><br>
<br>
After we&#39;ve verified the information is correct, we&#39;ll check &#39;Enabled PG connection&#39;. In this case, we&#39;ll also check &#39;Self-signed&#39;.<br>
<br>
<img src="https://github.com/ajstadlin/SIEGate/blob/master/Source/Documentation/wiki/Creating_Secured_Gateway_Connections.files/13.png" alt="13.png" title="13.png"><br>
<br>
Next, hit &#39;Save&#39;.<br>
<br>
<img src="https://github.com/ajstadlin/SIEGate/blob/master/Source/Documentation/wiki/Creating_Secured_Gateway_Connections.files/14.png" alt="14.png" title="14.png"><br>
<br>
At this point, the publisher know the subscribers information, and will allow the connection. However, there are no measurements authorized, and there is no connection enable the other direction.<br>
<br>
First, we&#39;ll create an authorization request from this system (<span class="codeInline">DEMO01SIEGate</span>) to the first one ({DEMO02SIEGate}}). In this connection, the publisher and subscriber roles will be reversed, giving us a true, bidirectional
 path for data exchange.<br>
<br>
<img src="https://github.com/ajstadlin/SIEGate/blob/master/Source/Documentation/wiki/Creating_Secured_Gateway_Connections.files/01.png" alt="01.png" title="01.png"><br>
<br>
This will be filled out very similarly to the first connection:<br>
<br>
<img src="https://github.com/ajstadlin/SIEGate/blob/master/Source/Documentation/wiki/Creating_Secured_Gateway_Connections.files/15.png" alt="15.png" title="15.png"><br>
<br>
Save the file, and transfer it securely to the other SIEGate.<br>
<br>
Now that we have the reverse connection setup, we&#39;ll authorise some measurements to be shared. On this system (<span class="codeInline">DEMO01SIEGATE</span>) we have some points available. To authorise the points, click on &#39;Publication&#39; -&gt;
 &#39;Subscriber Measurement Access&#39;.<br>
<br>
<img src="https://github.com/ajstadlin/SIEGate/blob/master/Source/Documentation/wiki/Creating_Secured_Gateway_Connections.files/16.png" alt="16.png" title="16.png"><br>
<br>
By default, no measurements are shared:<br>
<br>
<img src="https://github.com/ajstadlin/SIEGate/blob/master/Source/Documentation/wiki/Creating_Secured_Gateway_Connections.files/17.png" alt="17.png" title="17.png"><br>
<br>
Using the Search box on the right, we&#39;ll pick out the Frequency measurement:<br>
<br>
<img src="https://github.com/ajstadlin/SIEGate/blob/master/Source/Documentation/wiki/Creating_Secured_Gateway_Connections.files/18.png" alt="18.png" title="18.png"><br>
<br>
Tick the box next to the measurement, and hit &#39;&lt;&lt;&#39; to move to the authorised list.<br>
<br>
<img src="https://github.com/ajstadlin/SIEGate/blob/master/Source/Documentation/wiki/Creating_Secured_Gateway_Connections.files/19.png" alt="19.png" title="19.png"><br>
<br>
At this point, we have completed everything we need to do on this publisher system. Now, we&#39;ll return to
<span class="codeInline">DEMO02SIEGATE</span><br>
<br>
On the Browse Devices page, locate the new connection, and ensure &#39;Enabled&#39; is checked.<br>
<br>
<img src="https://github.com/ajstadlin/SIEGate/blob/master/Source/Documentation/wiki/Creating_Secured_Gateway_Connections.files/21.png" alt="21.png" title="21.png"><br>
<br>
Next, go to &#39;Subscriber&#39; -&gt; &#39;Measurement Subscriptions&#39; <br>
<br>
<img src="https://github.com/ajstadlin/SIEGate/blob/master/Source/Documentation/wiki/Creating_Secured_Gateway_Connections.files/22.png" alt="22.png" title="22.png"><br>
<br>
On this page, we&#39;ll see the measurement that was made available.<br>
<br>
<img src="https://github.com/ajstadlin/SIEGate/blob/master/Source/Documentation/wiki/Creating_Secured_Gateway_Connections.files/23.png" alt="23.png" title="23.png"><br>
<br>
Tick the checkbox, and move it over to &#39;Subscribed&#39; with the &#39;&lt;&lt;&#39; button.<br>
<br>
<img src="https://github.com/ajstadlin/SIEGate/blob/master/Source/Documentation/wiki/Creating_Secured_Gateway_Connections.files/24.png" alt="24.png" title="24.png"><br>
<br>
To verify data is flowing, we&#39;ll check the graph measurements screen.<br>
<br>
<img src="https://github.com/ajstadlin/SIEGate/blob/master/Source/Documentation/wiki/Creating_Secured_Gateway_Connections.files/25.png" alt="25.png" title="25.png"></div>
<div></div>

            
</div>

<hr />
<div class="footer">
Last edited Oct 3, 2013 at 9:20:26 PM by <a id="wikiEditByLink" href="https://www.codeplex.com/site/users/view/arkrohne">arkrohne</a>, version 2<br />
<!--HtmlToGmd.Migration-->Migrated from <a href="https://siegate.codeplex.com/wikipage?title=Creating%20secured%20gateway%20connections&referringTitle=Documentation">CodePlex</a> Nov 8, 2015 by <a href="https://github.com/ajstadlin">ajstadlin</a><!--/HtmlToGmd.Migration-->
</div>

<!--HtmlToGmd.Foot-->
<div id="copyright">
<hr />
Copyright 2015 <a href="http://www.gridprotectionalliance.org">Grid Protection Alliance</a>
</div>
<!--/HtmlToGmd.Foot-->
</body>
</html>