# Code-Documentation-Checkin-Policy
This tfs checkin policy for Visual Studio 2010,2012,2013 &amp; 2015 checks if c# code is documented the way it's configured in the config of the policy. 

**Versioning Hint**

All versions are compatible as long as only the revision and build part of the vsix package are different.
Compatible does mean, that a TFS administrator does not have to update the registration of the policy and that people can use different versions of the policy as long as the version number is higher than the one registered with TFS and that the major and minor part of the version is the same.

**Compatible versions:**
* 0.3.0.0 --> 0.3.0.1 
* 0.3.0.0 --> 0.3.99.99 
* 0.3.0.0 --> 0.3.X.X 
* 0.4.0.0 --> 0.4.0.1 
* 0.4.0.0 --> 0.4.99.99 
* 0.4.0.0 --> 0.4.X.X

**Incompatible versions:**
* 0.3.0.0 --> 0.4.0.1 
* 0.3.0.0 --> 1.3.0.0 
* 0.4.0.0 --> 0.5.0.0 
* 0.4.0.0 --> 0.3.0.0 
* 0.4.1.1 --> 0.5.0.0 
* 0.3.0.1 --> 0.3.0.0 
* 0.3.99.99 --> 0.3.0.0
