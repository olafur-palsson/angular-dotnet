import { ElementRef, Injector, Pipe, PipeTransform } from '@angular/core';
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

    l(key: string): string {
        let localizedText = this.localization.localize(key, this.localizationSourceName);

        if (!localizedText) {
            localizedText = key;
        }
        return localizedText
    }

    isGranted(permissionName: string): boolean {
        return this.permission.isGranted(permissionName);
    }
}

@Pipe({ name: 'localize' })
export class LocalizePipe extends Localizer implements PipeTransform {
    constructor(injector: Injector) {
        super(injector);
    }

    transform(key: string): string {
        return this.l(key);
    }
}

