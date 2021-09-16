import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientJsonpModule } from '@angular/common/http';
import { HttpClientModule } from '@angular/common/http';
import { ModalModule } from 'ngx-bootstrap/modal';
import { ServiceProxyModule } from '@shared/service-proxies/service-proxy.module';
import { SharedModule } from '@shared/shared.module';
import { AccountComponent } from './account.component';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import { AccountLanguagesComponent } from './layout/account-languages.component';
import { AccountHeaderComponent } from './layout/account-header.component';
import { Footer } from './layout/footer';
import { RouterModule } from '@angular/router';

@NgModule({
    imports: [
        RouterModule.forChild([
            {
                path: '',
                component: AccountComponent,
                children: [
                    { path: 'login', component: LoginComponent },
                    { path: 'register', component: RegisterComponent }
                ]
            }
        ])
    ],
    exports: [
        RouterModule
    ]
})
class Router { }

// tenants
import { TenantChangeComponent } from './tenant/tenant-change.component';
import { TenantChangeDialogComponent } from './tenant/tenant-change-dialog.component';

@NgModule({
    imports: [
        CommonModule,
        FormsModule,
        HttpClientModule,
        HttpClientJsonpModule,
        SharedModule,
        ServiceProxyModule,
        Router,
        ModalModule.forChild()
    ],
    declarations: [
        AccountComponent,
        LoginComponent,
        RegisterComponent,
        AccountLanguagesComponent,
        AccountHeaderComponent,
        Footer,
        // tenant
        TenantChangeComponent,
        TenantChangeDialogComponent,
    ],
    entryComponents: [
        // tenant
        TenantChangeDialogComponent
    ]
})
export class AccountModule {

}
