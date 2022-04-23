import requests
import json
import os
from requests.packages.urllib3.exceptions import InsecureRequestWarning
requests.packages.urllib3.disable_warnings(InsecureRequestWarning)
headers = {"Accept": "application/json","Content-Type": "application/json"}
data = {'username': 'mphu1@asu.edu', 'password': 'PACapstone1$'}
endpoints = {"stat/health", "self", "stat/ccode", "stat/current-channel", "stat/sysinfo", "stat/event", "rest/event", "stat/alarm", "rest/alarm", "stat/sta", "rest/user", "stat/device-basic", "stat/device", "rest/setting", "stat/routing", "rest/routing", "rest/firewallrule", "rest/firewallgroup", "rest/wlanconf", "rest/tag", "stat/rougeap", "stat/dynamicdns", "rest/dynamicdns", "rest/portconf", "stat/spectrumscan", "rest/radiusprofile", "rest/account", "rest/portforward"}
s = requests.Session()
r = s.post('https://192.168.1.1/api/auth/login', headers = headers,  json = data , verify = False, timeout = 10)

for endpoint in endpoints:
    endpointResponse = s.get('https://192.168.1.1/proxy/network/api/s/default/'+endpoint, headers = headers, verify = False, timeout = 1)
    parsed = json.loads(endpointResponse.text)
    json_object = json.dumps(parsed, indent=4, sort_keys=True)
    completeName = os.path.join("../GetJson/"+ endpoint+".json") 
    with open(completeName, "w") as outfile:
        outfile.write(json_object)

#print(r.status_code)
#print(s.get('https://192.168.1.1/proxy/network/api/s/default/stat/sysinfo', headers = headers, verify = False, timeout = 1).text)

