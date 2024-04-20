﻿// --------------------------------------------
// 预定错误提示语
// --------------------------------------------
let errtxt = {
    // 3位数约定为固定错误
    200: '服务器返回成功',
    500: '服务器发生异常',
    510: '拒绝请求',
    600: '操作失败',
    601: '没有数据',
    602: '参数错误',
    603: '数据库错误',
    // 4位数约定为自定义错误
    4001: '更新失败,源数据错误',
    4002: '未更新,内容没有修改',
    4003: '更新失败,无权操作'
};
// --
ns.errtxt = errtxt;