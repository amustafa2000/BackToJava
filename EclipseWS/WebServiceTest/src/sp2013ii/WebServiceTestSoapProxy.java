package sp2013ii;

public class WebServiceTestSoapProxy implements sp2013ii.WebServiceTestSoap {
  private String _endpoint = null;
  private sp2013ii.WebServiceTestSoap webServiceTestSoap = null;
  
  public WebServiceTestSoapProxy() {
    _initWebServiceTestSoapProxy();
  }
  
  public WebServiceTestSoapProxy(String endpoint) {
    _endpoint = endpoint;
    _initWebServiceTestSoapProxy();
  }
  
  private void _initWebServiceTestSoapProxy() {
    try {
      webServiceTestSoap = (new sp2013ii.WebServiceTestLocator()).getWebServiceTestSoap();
      if (webServiceTestSoap != null) {
        if (_endpoint != null)
          ((javax.xml.rpc.Stub)webServiceTestSoap)._setProperty("javax.xml.rpc.service.endpoint.address", _endpoint);
        else
          _endpoint = (String)((javax.xml.rpc.Stub)webServiceTestSoap)._getProperty("javax.xml.rpc.service.endpoint.address");
      }
      
    }
    catch (javax.xml.rpc.ServiceException serviceException) {}
  }
  
  public String getEndpoint() {
    return _endpoint;
  }
  
  public void setEndpoint(String endpoint) {
    _endpoint = endpoint;
    if (webServiceTestSoap != null)
      ((javax.xml.rpc.Stub)webServiceTestSoap)._setProperty("javax.xml.rpc.service.endpoint.address", _endpoint);
    
  }
  
  public sp2013ii.WebServiceTestSoap getWebServiceTestSoap() {
    if (webServiceTestSoap == null)
      _initWebServiceTestSoapProxy();
    return webServiceTestSoap;
  }
  
  public java.lang.String helloWorld() throws java.rmi.RemoteException{
    if (webServiceTestSoap == null)
      _initWebServiceTestSoapProxy();
    return webServiceTestSoap.helloWorld();
  }
  
  
}