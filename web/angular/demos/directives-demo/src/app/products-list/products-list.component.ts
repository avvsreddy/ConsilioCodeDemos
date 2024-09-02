import { CommonModule, CurrencyPipe, NgFor } from '@angular/common';
import { Component } from '@angular/core';
import { IProduct } from '../../models/IProduct';

@Component({
  selector: 'app-products-list',
  standalone: true,
  imports: [CommonModule,CurrencyPipe],
  templateUrl: './products-list.component.html',
  styleUrl: './products-list.component.css'
})
export class ProductsListComponent {

productsList:IProduct[]=[
  {
    id:111,
    name:'IPhone 15',
    price:59600,
    inStock:true,
    image:'https://encrypted-tbn0.gstatic.com/shopping?q=tbn:ANd9GcR8lUYzOu3dzoSpr9MkhEvvx6g1n5urknsak726LOPA-CxJ9TRzZPkeXXGBey1sALqxlNKutTQLxdNX54gDNm8Ec-OVS4oDF9vL57TeELLJmrcWIE7_LHDFZjehC-zOagRqa9cD_A&usqp=CAc'
  },
  {
    id:222,
    name:'Galaxy S24',
    price:96600,
    inStock:false,
    image:'data:image/jpeg;base64,/9j/4AAQSkZJRgABAQAAAQABAAD/2wCEAAkGBxASEBUQERAVDxUVFRUPFRUVFQ8VFRAQFRUXFhUVFRUYHSggGBolHRUVITEhJSkrLi4uFx8zODMtNygtLisBCgoKDg0OFxAPFysdFx0rKy0tLS0tKys3KysrLSsrKystLS0tLSsrKy0rLSstKzcrLS0tKy0rLSsuKzc4Ky04K//AABEIAOEA4AMBIgACEQEDEQH/xAAcAAABBQEBAQAAAAAAAAAAAAAGAAECBQcEAwj/xABREAABAwICAwoJBwoEBAcAAAABAAIDBBEFIQYSMRMiQVFhcXJzkbMHIzIzUoGhstE1QnSCscHSFBdUVWSSlKLC8BWj4fElQ2JlJDRFU2O0w//EABcBAQEBAQAAAAAAAAAAAAAAAAABAgP/xAAbEQEBAQEBAQEBAAAAAAAAAAAAAQIRMSFBUf/aAAwDAQACEQMRAD8A29JJJAkkkkHhX+ak6D/dKDsPpmOijJa2+oz5kfojPZmeG540YYh5mToP90oTww+Jj6DPdCzpqJmij9Fv7sfwUTQx+iP3WfBUOm+lzKCJp1d1lkuI47kCzbBz3kZhgJtYZuNxcapKzE+E7E9fX1oCPR3CO1uLXHjP57qSHW1Ghj9Efus+CiaGP0R2M+CodC9L46+InV3KRhDZI76wBIJa5p2lhAO3MEEG+RJBUTtY0ve4Ma0FznEgBrQLkknYAFFeZoo/RHY34KJo4/RHY34KkotOcOll3FlRvidVusyRrXu2Wa5wsTxcfBdEGsg8TSR+iP3WfBR/JGeiOxvwXsSokoAzTOvngEbKZ7IXS1O5l7oYJCGCEOsA9pAFzfK2wKiNbin6fH/BUP4Vbae+XTfSz/8AXauLVXTM+I4nV+KfpzP4Oi/CvF2KYn+nM/g6L8KsXRLlmhV5EcxxbE/01n8JR/hUf8VxP9Ob/C0f4UnBQTkVa078SdCZnYlGxoJ1iaOis0AXJJsvGWrxECJ7cSjkilcY90bSURDXjYDlw2PNYq90fw5lRRSRPvqucWmxsRkCCDwEEA+pWtFolC2jfRs1rOu8PcQXbte4eSAM7gbBsCzfgHG02J/rJn8FR/BS/JcU/WTP4Kj+CscKc50V3jVewmKQejI3I/YV12QUn5Lin6yZ/A0fwT/k+KfrJn8DRfBXWqn1UFLuGKfrKP8AgaL4Kx0Mras1r6epmZUajqSVj2wQQluvIQR4sDI8pOwLosubRgf8Wm5qLviiNoSSSVQkkkkHPiHmZOrf7pQjhnmY7+gz3Qi7EPMydB/ulB+HHxMfQZ7oWdNRj/hia/8AL2ON9U07Qw8G9llDwOXWJP1gg0OYWZ2ba+fpg8B5R963nS/RuKti1Hg3adZjm2143EAEtvkQQAC07dUG4Ius3/NlJr2MxLeSN4d7Rq+1WaSx4+CYPFTI8X1dRkZ4i4yMcBzi1+1H3hQjkdh0gjBNix7wOGNrg52XJbW5mldOi+jjKVgAbqgZgbSXH5zjx/Zcq+kAIsc1nv1ePmYMc8hjAXucdVoGZc47AF9H4W524s1zd1sz6R4+Y7VzRaN0rHGZtOxpdtcGsBdfM6xAub7c9qsLpb0kSJUSUxKiSooE8IspbuDuKrv/AJDbrnpKhrxcJeFN3ioj+1HuGoTw7ESw7V1z4g4ay6jLTrxw+sDgM1ZOAVA5VxWK41eV0V1VSRZqg10IIFK8n/3bfyhFlKRtWdYfXblSDgvUAf5ZRVg+KBwGa56n1UMZpxDV7pbxdQNV/JK0ZHnIHa1eEsRaSD/uOAq+xanE8Dm8I3zTxOGYKq2eMiB+c0WI5vKHq29qxLy8HHZKynZKy0iFlw6NA/4vLzUPfFWNlwaNj/i83Roe+KqNnSSSVQkkkkHPiHmZOg/3Sg2gPimdBnuhF+LOIgkI26hGfLl96DaI+KZ0Ge6FnTUcOkmkMFFFusxJudVkbba8rhYkNvkAAWkuOQ1hkSQCAHwtSa//AJJmpxbtJr26Wrq/yKv8L8zzXRtN9VtO3UHBvpZS8jl1rj6o4kFhgIyyI8q58rPLVFssuNWZS19AaP6QwVkQlhJtfVc1wAfG+19VwGWzMEZEA8RAsiVjfgome2omA8ksZfpCVoaeexcPrFHPhJqZGYdKYyRcsY4jgjc9rXZ8t9XmcVmz6vfggjxqCR25MqYpHt2sa+Mubq5b5oN8uVe5K+cTJqaskbix7SC2xIcHg3DmW2AZct19B0ErnRNc4WdbMcR4QORLOErpJUSUxKgSooD8KQvDF9KPctWfg2WoaXwNkfSseNZrqxwI4xuAVVi2g17up3X/AOh5z+q/h5j2rrnxA1hOIFh25I0parWbdANVQSwvLXsc1w4CCDbjtwjlFwrfA8QI3pWgVOF1wVDAurdQBdV1VMTsCBsWktSNt+kf/mVLA8UItmq3F5iKUAi3jwf8t3wVVRVdisX1W04RiQcLXXEXGOdwGxx1h/f97EK4HilrZojqpg8NffZYHmXPcWO2ZnCNhz5ivMhe1O4EZnI+wnZn6vak+Mg2P+h9fErm9Sx5WVbo78rzdGh74q1sqjBiRitQRtEdGRfjEjiLqstoSSSWkJJJJBx4x5iTo/eEF0h8Wzq2e4EaYv5iTo/egemPi2dXH7gWdNQO6c6MNrY256kkdzG+xIAdm5j2jMsJzuLlpJyOsbZqNB6zW1S6MN2awkYb/UB1vVZbNiWIw08RmnkETAQNY3N3G9mMaM3uNibDiJNhmhD851BrW3CoA9PUgvz6m6ezWSdLx3aH6NtpmAC5z1nOIsZHcGXA0f3sRJUxNe0seA5rgWkEAggixBByIsbWK8aDEIp42ywyCVjr2cL8G0EHNrhcXBFxccBBPuSsqG6XQmhjlErIgCDrDOQ6p23Gs4gHiIAI4LIiaAAABYDIDiCRKiSgclRJTEqBKAc0nPjaQ/tju4CvYHof0qO/pD+2O7gK1gkXTPiLOpooZ2ak0YkHBfa08bXDNp5QhXFNBXsJkpjuw26jiGyDouyD/XY8pRRDIu+GVa6Mshlc1xY8FjxkWuBDm84K9ZnnjWm4jhdPVNDZ4w+3kuGT2dF4zHNsQVjOiNTBd0JNXGM7WG7NHK0ZP+rnyKygK0kkIp25/wDOHtjd8EPwylEGkMjXUtgcxUMBHCPFzA3HOFS01DK7Yw25ch2lZ1E6ucOrLcKLcPxMFuqT2oOZTRRC8s1z6EY1nesmwCgNIdQ+Jia3/qk8a7nsbMH7pXOq0yjrLt2WzIJ2b7nvYbTtVvBOHi2e93tjbWAsbcQtksww3HqiVw3WZzxlk4gNGrvjZgGqMg7MD7Lo+wc5nb5N/XcD+/uVzn4tqxsqfCflSp6qk7xyurKlwv5UqeqpO8ciNoSSSWmSSSUZCbGwubZC9rngF+BByYybU8h4mk+oIFgO8Z1cfuBEFXpZCd1gdFM17Y3OIbGZRqlps68WsQM+ECyHIjvGdXH7gWa1GY+FuteaqKC51GQiQDgMkr3a7uezI2/UQZJGCAWMIAADjcnfcJvbLmWp+EDRo1bWSRkCaMFg1iAJoiS7ULjkHBxcRfI65GVhfO4tH8RDjGKeVl8iSCG85PFyrWbP1mxf+Cque2WaK+8LWS24BI14be3K1zh2cS1MuQZoTo7+TsOsQ5ziC9w2ZZtY08OdiTxgIvJWK1EiVElMSokqKclRJUSVElANaZPt+Sn9rd3IXdSTXAVTp860VOf2t3chPhNTdq3EE0Mq7YpVSxSLrikV6LqKddTahUjJUqmubGx0jzZrGl7jxNaLn7ElAV4Ra2L/ABBjWNAeItaVwA3zid4D/wBQbfPicEP7qTwqlkxB81U6d/lSPLiOIHY3mAAHqV1E1aqRW4nBbfcHCqsDNFz6cOaWnhQxW0pY4gj/AGXNVhhDxrgeTsDiLjJ51Tc8xHrPJZahotIHM1h6IWOMmPHbm23Gw/ctd0JN2y8WuCOi4GRvse1X8oI7Kjw02xSp6qj7xyvrKnwT5Ym6ND3xUg2JJJJaZJVuP1hihJabEm1+IapP3W9askK6cVNmht/m3/eOXuHtUpAxgeIONRWSbnujnUzy4ggaoF7BoOWZIG1ekTt4zq4/cap6FU16esnI2gRNPIM3DtsvGI7xnVx921ZrT0JXOaWP0B2L1JUSVFOMkxKiSokoJEqJKiSokoJEqJKiSokoBbwgeZg+lO7kKrwaosbKz0+8xT/SndyEPUj7OBWvxBvC9dLHqvoHazQV2AIOpsiEvCPiurA2nac5Td3VtN7et1uwom1lkekmJflFS+S92+SzoDye3b9YqK4YXWcDyg+1F8LeFBoKOsKj14WP4x9mSvenHtDGubGcM12awGY+xWcMas4ILjYoMukjI2rXPB+9rqNhaLEWjfyvY1rB/IGIJ0mwYsdrtGRRv4PIS2hZlbWdI7+dzf6QqglVHhT9XF53WJsyidYWubSk5K9AVBQfKtR1VH3jlINmSSSW2SWdad1e/dnkCR+6A0+0O7Vob3gAuOwAk8wzWRaUSl79XaXENI43OO+9pKlWDHRahLMJt5LnskmNxffZ29jR2obad6zq4+7atDkp9zpTGPmQln7rLLOr5N6uPu2qVYclMSokqJKyqRKiSokqJKCRKiSokpiUDkqJKYlRJQDennmKf6U7ughxgRFpz5in+lu7oKijYqCHR+f5pREYEHYc/VcCjukeHMBQCemdduNMWg2dJeMcYbbfnsy5yFlpCK9N8Q3eodq+SzxbeUA753rd7oQ2IVm0eAC0DQnf02r6LiPVtQSymKNtAxqmRh4dV3ZcH7VOqvvyMgqwpIF3RwAhdUFNZWUcNXhrZGFpH+67sKpRFCyP0W+0kuP2qwbDkme2xtzD2LVR5qgw5hOLztBteOibe17XlIvb1ohsqHCflmXo0HfFIlbCkkktsuHGpdWB/LZnqcbO9l1mmFxbviULdtnmU8zd8bo40xqNWIN49Z3YNX+s9iGfBxT69XNNwMYGDkc43+y6zfV/B/iPmZOrf7pWYOOTerj7tq0/EfMydW/3SstefJ6uPu2ppYRKiSmJUSVlUiVElRumJQOSmJUbpiUDkqJKYlMSgoNNfM030t3dBVDWq40w81TfS3d0FWhqpDxqxqMWcyAtad87ejnOSrrqLGa7+Ro/mP8Apf2KCjfS3PsXpHQciIG0Y4l6ilHEsKpI6HkVzgEepLzgj7/uXpuC6KWKzgeVAW0RVrCxUeGyIipRcKD1axcsm085+1WDGZqvK31EbKgwr5Zm6NB3xRDZD2GfLMvRoO+K1ErYEkkltkD6eVW+Lb7AG9g1v6x2Lp8GdLq0jpSM5ZC7naMh96GdM6vWc4jhJI+sSW+whaHo5SblSQx7LRtJHEXDWI7SVmerXViPmZOrf7pWVyHyeri7tq1TEfMydW/3SsomPk9XF3bU0sMSokpiVElZVK6iSmJUSUEiVElNdMSgclRumuldBTaW+apfpbu6CryFYaWeapfpb+6C4HJSPKR1gTxK0w+kLWC4zO+dzng9WQ9S46Gn3SVreAb93MNg7be1E7KdZqq9sC9BArAQKYgQVu4J2wqy3FLcEHjh8lnEcRRdhuaCnbyU+o+wIxwB+tZY6q6Mdmk8QuqYBElQ20Tui77EO2W8ojZDuG/LUvRoO+KJEN4d8tS9Gg74rcZrX1z4hLqxPcDYhpt0jk32kLoVPpRUakHOfszH8wb2rbLOKuLd6yKEbHytbzNB+zILX1l+hEG64jr8ETHP9Z3o9pC1BSLXNiPmZOrf7pWTznNvVxd21aziPmZOrf7pWSVBzHVxd21TSx5kpiU11ElZVK6a6jdK6B7qJKV0yB010ySCo0r81S/S390FwFd+lPmqX6W/uguelpTLI2MfONieJu1x7AUpF3o1Q2j3QjN5uOgPJ+8+tXrYF1QU4AAAsALAcQGxe4iWVcIgT7iu7c0tzQcW4ptxXcY1HUQD+KRWeDxt9oJ+IV7ok/fWXDjcWTHcpb2i/wDSunRPztly161PBziItC7mt2kBDdkR4wfEHlLR7QfuQ8uufGKjZDWH/LUvRoO+KJ0MUPy1L0aDvitxK15CGndRYNZxD3iT/Q3tRes207qgXv4QCfVq7z+k9q1Ujv8ABfTb2ec/OeIweRuZ+1qOlQaC0m5UEQIsXAyHnccj2AK/SJXNiPmZOrf7pWRVJzHVxd21a7iPmZOrf7pWQ1RzHVxd21TTUeV01010yyp7prpkroHumTJIHTJkkFXpP5ql+lv7oK+0Nw++tOR/8beba49th6iqPSKMuZSNaLl1Y5oHGTEAFouH0jYo2xt2NFr8Z4T6zc+tSkTEafUXpdOFFeeom1F7AcifV5FBz6qbUXuWpavIqK/E4rx8xB9tvvK8dHzacDlXXVglpyOWfDwZrnpW6szXcq5bagxxt3imjjcOyxVFZW+LPuxnrPYB8VU2XXPjFRshei+WpejQd8UVWQtR/LcvRoO+K3Ea1NIGtLjsaC48wF1kWkbnSSiPyi5zWc5yB+9ajjsurA7ls31X33sBWb4FDu2JxA5hrjMfq5i6tSNTpoQxjWDY1oYOZoAH2L0SSWkc+JeZk6t/ulY9V+UOri7pq2DEfMydW/3SserPKHVxd01Z01HjdJMmWVOovdknTII7p/fZ8U26KaZBEyf360mvz/vl+CkldB51Q39D9Mf3KK5aeQjK4Q0wXnw8ftr+4WiSQqaIC6qglO2Rw5i5V0uGcb3nne/4o4npFXz0Sig91A3hbfnuftTspGj5o7Ar+ak5FyugsiOJlKOIdik+NoF7D2Lqe4NFybDlVPW1wOQzQc9U8k5OI5iR9iOtFqOSaNrnusRmCfnDl4+ftugvDmEuuWggZ76+3iA48kZ4BiBL9zZwXJ5BxqX+LBNXONmtO0A/37FyWXrI6+ZXmQtT4hkK0vy3L0aDviitClN8ty9Gg74rUSjnTOp1Yg0HaCT7AL9ruxD/AINIdaoqJrX1WtjB4iTfI+oro08qd8RxAN7Brf1nsVh4NaXVot0O2V7n/VGQ9t1f1PwVpJJLSObEfMydW/3SsdrPKHVxd01bFiXmJerf7pWN1Z3w6uLu2rOmo8kyZJZUkkySB0kyZA6SSSD1ph/4jD/pr+4K1ExrLqZ1qjDz+2v7grUJKriHapoiD4VyVEbQMyBzqU9S48NuZVdSbrKuHEq5jfJaXnsHac/YhitxGU7LMHILntKvatoVBWtCoqZHOJuSXHjJJXpCwHNxsNnPzfFJ4A258Q+K8nvceG33cnIg7mzlxaxguTZjWjaSbAAcZWhYHhgp4g02L3WLzxu9EHiGwevjVLoXgeoPymUb9w8WD8xhFtbkJHs58iqysiWmSKdJEMhKn+W5ejQd8UXWQjB8uS9HD++KsHtptUaz3AHynED6ziR7CFpOC0m408UVrarGg9K13e0lB1LgTp8RLnDxVO/fH05AA5rAOYtJ5Cj5biUkkklUc2JeZk6t/ulY3W+UOri7pi2TEvMS9W/3SsbrhvmngMUJBuCCDEziWdNRzpJrqOuNl1lU0yjrjjS3QcaCSShug40t0bxoJp1DdG8aW6N40HrGfH4f9Nf3C0OWZZpWvkaymqIojOIKsve1hYHAOisMieQrsl00lP8A6fUdsPxSwgxmqQq2oq0Kv0skO2gn7YfivMaVOOYoJ+2H4qcp1eTyOcqyoZblPsH+q45tKH2s2hnHLeL2ZrnbjzuGhn7YvipynXV+Tq70dwHdX7pI3xbTsP8AzHejzcfZwqih0kA20FR2w/FXUXhAa1oa3DqgAZDOD8SslLR0kgj84g/V1T2wfiT/AJw/+3VPbB+JXiDZJBP5wv8At1T2wfiSHhD4P8Oqe2D8ScBshGD5cl6NB3xXh+cA/q2p7YPxLy0drH1GJSVboHUzHOoYGiR0es57ZSTYA86sRscO13S/pC9AkktoRSCSSCMnknmP2IHZsSSUEkkkkUkySSIdJMkgSdJJFctf5t/Qd7pWfv2u5n+6UklKsaOUydJVDtUkkkQkkkkCSTJIHSSSQJe+G+fj6QSSQf/Z'
  },
  {
    id:333,
    name:'Dell XPS',
    price:18600,
    inStock:true,
    image:'https://encrypted-tbn2.gstatic.com/shopping?q=tbn:ANd9GcREKkuwkr1r3cUJBYORNwxF-TzyvC56PowWGJ8dj_jXzPV7pGTjcAZ5lZaZZrQc9pAxELU8A4s_jKafT0LezH-Jjc-2trUeV1bTXsWQeqQCrFl4y8_c8sPJcXO6tFDKBuAcQmqHRQ&usqp=CAc'
  },
  {
    id:444,
    name:'IWatch 7',
    price:95600,
    inStock:false,
    image:'data:image/jpeg;base64,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'
  },
  {
    id:555,
    name:'Galaxy Watch',
    price:5600,
    inStock:true,
    image:'data:image/jpeg;base64,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'
  }
]


}