﻿# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------
<#
.SYNOPSIS
GetLocationKindDirect 
#>
function Test-GetLocationKindDirect {
    try {
        $asn = 65000
        $asnPeerName = makePeerAsn $asn
        $location = Get-AzPeeringLocation -Kind Direct 
        Assert-NotNull $location
        Assert-True { $location.Count -gt 30 }
    }
    finally {
        Remove-AzPeerAsn -Name $asnPeerName -Force
    }
}
<#
.SYNOPSIS
GetLocationKindDirect
#>
function Test-GetLocationKindExchange {
    try {
        $asn = 65000
        $asnPeerName = makePeerAsn $asn
        $location = Get-AzPeeringLocation -Kind Exchange 
        Assert-NotNull $location
        Assert-True { $location.Count -gt 60 }
    }
    finally {
        Remove-AzPeerAsn -Name $asnPeerName -Force
    }
}
<#
.SYNOPSIS
GetLocationKindExchangeSeattle
#>
function Test-GetLocationKindExchangeSeattle {
    try {
        $asn = 65000
        $asnPeerName = makePeerAsn $asn
        $location = Get-AzPeeringLocation -Kind Exchange -PeeringLocation seattle
        Assert-NotNull $location
        Assert-AreEqual 5 $location.Count
    }
    finally {
        Remove-AzPeerAsn -Name $asnPeerName -Force
    }
}
<#
.SYNOPSIS
GetLocationKindDirectSeattle
#>
function Test-GetLocationKindDirectSeattle {
    try {
        $asn = 65000
        $asnPeerName = makePeerAsn $asn
        $location = Get-AzPeeringLocation -Kind Direct -PeeringLocation seattle
        Assert-NotNull $location
        Assert-AreEqual 2 $location.Count
    }
    finally {
        Remove-AzPeerAsn -Name $asnPeerName -Force
    }
}

