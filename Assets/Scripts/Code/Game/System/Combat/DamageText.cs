using System;
using UnityEngine;
using UnityEngine.UI;

namespace TaoTie
{
    /// <summary>
    /// 伤害飘字
    /// </summary>
    public sealed class DamageText : IDisposable
    {
        public static DamageText Create(UIDamageView uiDamageView)
        {
            var res = ObjectPool.Instance.Fetch<DamageText>();
            res.OnInit(uiDamageView).Coroutine();
            return res;
        }

        public bool IsDispose { get; private set; }
        public long ExpireTime { get; private set; }

        private UIDamageView uiDamageView;
        private RectTransform rect;
        private int showDmg;
        private Vector3 showPos;

        async ETTask OnInit(UIDamageView uiDamageView)
        {
            IsDispose = false;
            this.uiDamageView = uiDamageView;
            string resPath = "UIGame/UIMain/Prefabs/UIFightText.prefab";
            var obj = await GameObjectPoolManager.Instance.GetGameObjectAsync(resPath);
            if (IsDispose) //加载过来已经被销毁了
            {
                GameObjectPoolManager.Instance.RecycleGameObject(obj);
                return;
            }

            rect = obj.GetComponent<RectTransform>();
            OnGameObjectLoad();
        }

        void OnGameObjectLoad()
        {
            if (uiDamageView != null && rect != null)
            {
                rect.SetParent(uiDamageView.GetTransform());
                rect.localPosition = Vector3.zero;
                rect.localScale = Vector3.one;
            }

            UpdateText();
        }

        public void SetData(int finalDmg, Vector3 pos, long time)
        {
            showDmg = finalDmg;
            showPos = pos;
            ExpireTime = time;
            UpdateText();
        }

        public void UpdateText()
        {
            if (rect == null)
            {
                return;
            }

            var text = rect.GetComponentInChildren<TMPro.TMP_Text>();
            if (text != null)
            {
                text.text = showDmg.ToString();
                Vector2 pt = CameraManager.Instance.MainCamera().WorldToScreenPoint(showPos) *
                             UIManager.Instance.ScreenSizeFlag;
                rect.anchoredPosition = pt;
            }
        }

        public void Dispose()
        {
            if (IsDispose) return;
            IsDispose = true;
            if (rect != null)
            {
                GameObjectPoolManager.Instance.RecycleGameObject(rect.gameObject);
            }

            ObjectPool.Instance.Recycle(this);
        }
    }
}