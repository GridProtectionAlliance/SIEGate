<html lang="en">
<head>
</head>
<body>
<!--HtmlToGmd.Body-->
<div id="NavigationMenu">
<h1><a href="https://github.com/GridProtectionAlliance/SIEGate/blob/master/Source/Documentation/wiki/SIEGate.md">
<img src="https://github.com/GridProtectionAlliance/SIEGate/blob/master/Source/Documentation/wiki/SIEGate_Logo.png" alt="SIEGate" /></a></h1>
<hr />
<table style="width: 100%; border-collapse: collapse; border: 0px solid gray;">
<tr>
<td style="width: 25%; text-align:center;"><b><a href="http://www.gridprotectionalliance.com">Grid Protection Alliance</a></b></td>
<td style="width: 25%; text-align:center;"><b><a href="https://github.com/GridProtectionAlliance/SIEGate">SIEGate Project on GitHub</a></b></td>
<td style="width: 25%; text-align:center;"><b><a href="https://github.com/GridProtectionAlliance/SIEGate/blob/master/Source/Documentation/wiki/SIEGate.md">SIEGate Wiki</a></b></td>
<td style="width: 25%; text-align:center;"><b><a href="https://github.com/GridProtectionAlliance/SIEGate/blob/master/Source/Documentation/wiki/SIEGate_Documentation.md">SIEGate Documentation</a></b></td>
</tr>
</table>
</div>
<hr />
<!--/HtmlToGmd.Body-->
<div class="WikiContent">
<div class="wikidoc">These steps will show you how to create a bidirectional, internal connection between your openPDC and your SIEGate nodes. This type of connection should only be used
<b>internally</b>. If you are creating a connection over an unsecured network, please see
<a href="https://siegate.codeplex.com/wikipage?title=Creating%20secured%20gateway%20connections&referringTitle=Creating%20internal%20gateway%20connections">
Creating secured gateway connections</a>. Note that very similar steps will apply for creating GEP internal subscriptions between two openPDCs or two SIEGate instances as well.<br>
<br>
In this demonstration setup, we have an openPDC (<span class="codeInline">DEMO02PDC</span>) with sample data flowing in, and a SIEGate (<span class="codeInline">DEMO01SIEGATE</span>) we wish to connect to.
<br>
<br>
We&#39;ll start with SIEGate. In the menu, click on &#39;Subscription&#39; -&gt; &#39;Create Internal Subscription&#39;.<br>
<br>
<img src="https://github.com/GridProtectionAlliance/SIEGate/blob/master/Source/Documentation/wiki/Creating_Internal_Gateway_Connections.files/02.png" alt="02.png" title="02.png"><br>
<br>
On the &#39;Create subscription&#39; page, there are five things we need to enter; Acronym, Name, Hostname, Port, and which data to receive.
<br>
<br>
<img src="https://github.com/GridProtectionAlliance/SIEGate/blob/master/Source/Documentation/wiki/Creating_Internal_Gateway_Connections.files/03.png" alt="03.png" title="03.png"><br>
<br>
A brief explanation of these. Acronym refers to the short identifier for the publisher (the system we are connecting to and receiving data from) that will be used to refer to this connection. The name is longer and more descriptive, and does not have the same
 restrictions. Hostname is the IP address or the hostname of the system that we are planning on connecting to. The port is different depending on which product you are connecting to, and can also vary based on the configuration. The default ports for openPDC
 and SIEGate are listed for convenience. Selecting what data to receive is generally a matter of following the chart and checking the correct box(es).<br>
<br>
In this case, the settings will appear as follows:<br>
<br>
<img src="https://github.com/GridProtectionAlliance/SIEGate/blob/master/Source/Documentation/wiki/Creating_Internal_Gateway_Connections.files/04.png" alt="04.png" title="04.png"><br>
<br>
Once we click save, we&#39;re taken to the device configuration page. We can fill in more specific details about the connection we&#39;ve setup, and can hit &#39;Save&#39; to enable and start this connection.<br>
<br>
<img src="https://github.com/GridProtectionAlliance/SIEGate/blob/master/Source/Documentation/wiki/Creating_Internal_Gateway_Connections.files/06.png" alt="06.png" title="06.png"><br>
<br>
After we&#39;ve saved, we&#39;re taken to the Devices list. The connection has already started, and it&#39;s found our sample (Shelby) device.<br>
<br>
<img src="https://github.com/GridProtectionAlliance/SIEGate/blob/master/Source/Documentation/wiki/Creating_Internal_Gateway_Connections.files/07.png" alt="07.png" title="07.png"><br>
<br>
A quick look at the graph measurements screen shows data has started to flow, as well.<br>
<br>
<img src="https://github.com/GridProtectionAlliance/SIEGate/blob/master/Source/Documentation/wiki/Creating_Internal_Gateway_Connections.files/08.png" alt="08.png" title="08.png"><br>
<br>
If we want to create the reverse of this connection, a very similar series of steps can be followed. First, in the menu, click &#39;Inputs&#39; -&gt; &#39;Subscription Based Inputs&#39; -&gt; &#39;Create Internal Subscription&#39;.<br>
<br>
<img src="https://github.com/GridProtectionAlliance/SIEGate/blob/master/Source/Documentation/wiki/Creating_Internal_Gateway_Connections.files/11.png" alt="11.png" title="11.png"><br>
<br>
The steps from there are identical to the previous, with the exception of which data we wish to receive. Because the SIEGate is externally-facing, we&#39;ll want to grab the External metadata.<br>
<br>
<img src="https://github.com/GridProtectionAlliance/SIEGate/blob/master/Source/Documentation/wiki/Creating_Internal_Gateway_Connections.files/13.png" alt="13.png" title="13.png"><br>
<br>
<img src="https://github.com/GridProtectionAlliance/SIEGate/blob/master/Source/Documentation/wiki/Creating_Internal_Gateway_Connections.files/15.png" alt="15.png" title="15.png"><br>
<br>
<img src="https://github.com/GridProtectionAlliance/SIEGate/blob/master/Source/Documentation/wiki/Creating_Internal_Gateway_Connections.files/16.png" alt="16.png" title="16.png"></div>
</div>
<hr />
<div class="footer">
Last edited Oct 14, 2013 at 2:58:49 PM by <a id="wikiEditByLink" href="https://github.com/ritchiecarroll">ritchiecarroll</a>, version 4<br />
<!--HtmlToGmd.Migration-->Migrated from <a href="https://siegate.codeplex.com/wikipage?title=Creating%20internal%20gateway%20connections&referringTitle=Documentation">CodePlex</a> Nov 8, 2015 by <a href="https://github.com/ajstadlin">ajstadlin</a><!--/HtmlToGmd.Migration-->
</div>
<!--HtmlToGmd.Foot-->
<div id="copyright">
<hr />
Copyright 2015 <a href="http://www.gridprotectionalliance.org">Grid Protection Alliance</a>
</div>
<!--/HtmlToGmd.Foot-->
</body>
</html>