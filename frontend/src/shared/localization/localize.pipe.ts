import { ElementRef, Injector, Pipe, PipeTransform } from '@angular/core';
import { AppComponentBase } from '@shared/app-component-base';
import { AppConsts } from '../AppConsts';
import {
    AbpMultiTenancyService,
    FeatureCheckerService,
    LocalizationService,
    MessageService,
    NotifyService,
    PermissionCheckerService,
    SettingService
} from 'abp-ng2-module';
import { AppSessionService } from '../session/app-session.service';

class Localizer {
    localizationSourceName = AppConsts.localization.defaultLocalizationSourceName;
    localization: LocalizationService;
    permission: PermissionCheckerService;
    feature: FeatureCheckerService;
    notify: NotifyService;
    setting: SettingService;
    message: MessageService;
    multiTenancy: AbpMultiTenancyService;
    appSession: AppSessionService;
    elementRef: ElementRef;

    constructor(injector: Injector) {
    this.localization = injector.get(LocalizationService);
    }

    l(key: string, ...args: any[]): string {
        let localizedText = this.localization.localize(key, this.localizationSourceName);

        if (!localizedText) {
            localizedText = key;
        }

        if (!args || !args.length) {
            return localizedText;
        }

        args.unshift(localizedText);
        return abp.utils.formatString.apply(this, args);
    }

    isGranted(permissionName: string): boolean {
        return this.permission.isGranted(permissionName);
    }
}

@Pipe({ name: 'localize' })
export class LocalizePipe extends AppComponentBase implements PipeTransform {
    constructor(injector: Injector) {
        super(injector);
    }

    transform(key: string, ...args: any[]): string {
        return this.l(key, ...args);
    }
}

